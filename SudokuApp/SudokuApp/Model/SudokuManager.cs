using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using SudokuApp.Solver;
using SudokuApp.view;
using SudokuApp.WebApiClient;

namespace SudokuApp.Model
{
    public class SudokuManager : ISudokuManager
    {
        // The SudokuManager works internally with integer arrays.
        // It gets string arrays from the view model or from the WebApi.
        // It returns string and bool arrays to the view model.

        const int NumberOfSudokuFields = 81;
        const int SudokuSquareLength = 9;
        private readonly SudokuSolver sudokuSolver;
        private readonly StandardAsyncHttpClient httpClient;

        public SudokuManager()
        {
            this.sudokuSolver = new SudokuSolver();
            this.httpClient = new StandardAsyncHttpClient();
        }

        #region public methods -------------------------------------------------

        // This method is only used for manual tests without the web api
        public string[] GetNewSudokuStringArray()
        {
            int[] sudokuIntArray = new int[]
            {
                0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0,
                0, 0, 0, 0, 0, 0, 0, 0, 0,
                8, 5, 9, 7, 6, 1, 4, 2, 3,
                4, 2, 0, 8, 0, 0, 7, 9, 1,
                7, 1, 3, 9, 2, 4, 8, 5, 6,
                9, 6, 1, 5, 3, 7, 2, 8, 4,
                2, 8, 7, 4, 1, 9, 6, 3, 5,
                3, 4, 5, 2, 8, 6, 1, 7, 9
            };
            return ConvertIntToStringArray(sudokuIntArray);
        }

        public async Task<string[]> GetNewSudokuArrayAsync()
        {
            Random random=new Random();
            int numberOfApiPuzzles = 4;
            string id = random.Next(0, numberOfApiPuzzles).ToString();
            string spaghettistring;
            try
            {
                spaghettistring = await httpClient.SendRequestAsync<string>(new Uri("http://localhost:55555/sudoku/"+id), HttpMethod.Get);
            }
            catch (Exception e)
            {
                return ConvertStringToStringArray("WebApi unreachable");
            }
            if (spaghettistring.Length == NumberOfSudokuFields)
            {
                string[] stringArray = ConvertStringToStringArray(spaghettistring);
                int[] intArray = ConvertStringToIntArray(stringArray);
                intArray = RemoveInvalidEntries(intArray);
                stringArray = ConvertIntToStringArray(intArray);
                stringArray = RemoveZerosFromStringArray(stringArray);
                return stringArray;
            }
            return ConvertStringToStringArray("Invalid Puzzle length");
        }
        private string[] ConvertStringToStringArray(string inputString)
        {
            string[] stringArray = new string[NumberOfSudokuFields];
            for (int i = 0; i < inputString.Length; i++)
            {
                stringArray[i] = inputString[i].ToString();
            }
            return stringArray;
        }

        public string[] GetSolvedSudoku(string[] sudokuStringArray)
        {
            int[] sudokuIntArray = ConvertStringToIntArray(sudokuStringArray);
            sudokuIntArray = RemoveInvalidEntries(sudokuIntArray);
            sudokuIntArray = sudokuSolver.GetSolvedSudoku(sudokuIntArray);
            string[] solvedSudoku = ConvertIntToStringArray(sudokuIntArray);
            return solvedSudoku;
        }

        public string[] GetCheckedStringArray(string[] sudokuStringArray)
        {
            int[] sudokuIntArray = ConvertStringToIntArray(sudokuStringArray);
            sudokuIntArray = RemoveInvalidEntries(sudokuIntArray);
            return ConvertIntToStringArray(sudokuIntArray);
        }

        public FieldColor[] GetFieldColorArray(string[] sudokuStringArray)
        {
            int[] sudokuIntArray = ConvertStringToIntArray(sudokuStringArray);
            FieldColor[] sudokuFieldColorArray;

            bool sudokuHasEmptyFields = CheckSudokuForEmptyFields(sudokuIntArray);
            bool sudokuHasDuplicates = CheckSudokuForDuplicates(sudokuIntArray);

            if (!sudokuHasEmptyFields && !sudokuHasDuplicates)
            {
                // Sudoku is solved!
                sudokuFieldColorArray = MakeAllFieldsGreen();
            }
            else
            {
                // Sudoku has empty fields or Duplicates
                sudokuFieldColorArray = MakeDuplicatesRed(sudokuIntArray);
            }
            return sudokuFieldColorArray;
        }
        #endregion

        #region array conversion -----------------------------------------------
        private string[] ConvertIntToStringArray(int[] sudokuIntArray)
        {
            string[] sudokuStringArray = new string[NumberOfSudokuFields];
            for (int i = 0; i < sudokuIntArray.Length; i++)
            {
                sudokuStringArray[i] = sudokuIntArray[i].ToString();
            }
            sudokuStringArray = RemoveZerosFromStringArray(sudokuStringArray);
            return sudokuStringArray;
        }

        private string[] RemoveZerosFromStringArray(string[] sudokuStringArray)
        {
            for (int i = 0; i < sudokuStringArray.Length; i++)
            {
                sudokuStringArray[i] = sudokuStringArray[i].Equals("0") ? "" : sudokuStringArray[i];
            }
            return sudokuStringArray;
        }

        private int[] ConvertStringToIntArray(string[] sudokuStringArray)
        {
            int[] sudokuIntArray = new int[NumberOfSudokuFields];
            for (int i = 0; i < sudokuStringArray.Length; i++)
            {
                int.TryParse(sudokuStringArray[i], out sudokuIntArray[i]);
            }
            sudokuIntArray = RemoveInvalidEntries(sudokuIntArray);
            return sudokuIntArray;
        }
        private int[] RemoveInvalidEntries(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] < 1 || intArray[i] > 9)
                {
                    intArray[i] = 0;
                }
            }
            return intArray;
        }
        #endregion

        #region check sudoku -------------------------------------------
        private bool CheckSudokuForEmptyFields(int[] sudokuIntArray)
        {
            bool hasEmptyFields = false;
            foreach (var fieldValue in sudokuIntArray)
            {
                if (fieldValue == 0)
                {
                    hasEmptyFields = true;
                }
            }
            return hasEmptyFields;
        }
        private bool CheckSudokuForDuplicates(int[] sudokuIntArray)
        {
            bool[] duplicatesArray = GetDuplicatesArray(sudokuIntArray);
            bool sudokuHasDuplicates = CheckDuplicateArrayForDuplicates(duplicatesArray);
            return sudokuHasDuplicates;
        }

        private bool[] GetDuplicatesArray(int[] sudokuIntArray)
        {
            bool[] duplicatesArray = new bool[NumberOfSudokuFields];

            for (int j = 0; j < sudokuIntArray.Length; j++)
            {
                if (sudokuIntArray[j] != 0)
                {
                    if (CheckFieldForColumnDuplicate(j, sudokuIntArray))
                    {
                        duplicatesArray[j] = true;
                    }

                    if (CheckFieldForRowDuplicate(j, sudokuIntArray))
                    {
                        duplicatesArray[j] = true;
                    }

                    if (CheckFieldForSectorDuplicate(j, sudokuIntArray))
                    {
                        duplicatesArray[j] = true;
                    }
                }
            }
            return duplicatesArray;
        }

        private int GetRowNumberOfField(int fieldArrayIndex)
        {
            // fieldNumber=1-81 / RowNumber=1-9 
            int fieldNumber = fieldArrayIndex + 1;
            int rowNumber = 1;
            while (fieldNumber > SudokuSquareLength)
            {
                fieldNumber -= SudokuSquareLength;
                rowNumber++;
            }
            return rowNumber;
        }

        private int GetColumnNumberOfField(int fieldArrayIndex)
        {
            // FieldNumber=1-81 / ColumnNumber=1-9 
            int fieldNumber = fieldArrayIndex + 1;
            while (fieldNumber > SudokuSquareLength)
            {
                fieldNumber -= SudokuSquareLength;
            }
            int columnNumber = fieldNumber;
            return columnNumber;
        }

        private int GetSectorNumberOfField(int fieldArrayIndex)
        {
            // FieldNumber=1-81 / SectorNumber=1-9
            int rowNumber = GetRowNumberOfField(fieldArrayIndex);
            int columnNumber = GetColumnNumberOfField(fieldArrayIndex);

            int sudokuSectorLength = 3;

            int sectorNumber = 1;
            while (rowNumber > sudokuSectorLength)
            {
                rowNumber -= sudokuSectorLength;
                sectorNumber += 3;
            }

            while (columnNumber > sudokuSectorLength)
            {
                columnNumber -= sudokuSectorLength;
                sectorNumber++;
            }

            return sectorNumber;
        }

        private bool CheckFieldForColumnDuplicate(int currentFieldIndex, int[] intArray)
        {
            int duplicateCounter = 0;
            int currentValue = intArray[currentFieldIndex];
            int columnNumberOfCurrentField = GetColumnNumberOfField(currentFieldIndex);
            for (int i = 0; i < intArray.Length; i++)
            {
                if (GetColumnNumberOfField(i) == columnNumberOfCurrentField)
                {
                    if (intArray[i] == currentValue)
                    {
                        duplicateCounter++;
                    }
                }
            }
            return duplicateCounter > 1;
        }

        private bool CheckFieldForRowDuplicate(int currentFieldIndex, int[] intArray)
        {
            int duplicateCounter = 0;
            int currentValue = intArray[currentFieldIndex];
            int rowNumberOfCurrentField = GetRowNumberOfField(currentFieldIndex);
            for (int i = 0; i < intArray.Length; i++)
            {
                if (GetRowNumberOfField(i) == rowNumberOfCurrentField)
                {
                    if (intArray[i] == currentValue)
                    {
                        duplicateCounter++;
                    }
                }
            }
            return duplicateCounter > 1;
        }
        private bool CheckFieldForSectorDuplicate(int currentFieldIndex, int[] intArray)
        {
            int duplicateCounter = 0;
            int currentValue = intArray[currentFieldIndex];
            int sectorNumberOfCurrentField = GetSectorNumberOfField(currentFieldIndex);
            for (int i = 0; i < intArray.Length; i++)
            {
                if (GetSectorNumberOfField(i) == sectorNumberOfCurrentField)
                {
                    if (intArray[i] == currentValue)
                    {
                        duplicateCounter++;
                    }
                }
            }
            return duplicateCounter > 1;
        }

        private bool CheckDuplicateArrayForDuplicates(bool[] duplicatesArray)
        {
            bool duplicateArrayHasDuplicates = false;
            foreach (var fieldValue in duplicatesArray)
            {
                if (fieldValue)
                {
                    duplicateArrayHasDuplicates = true;
                }
            }
            return duplicateArrayHasDuplicates;
        }

        #endregion

        #region assign colors --------------------------------------------------

        private FieldColor[] MakeDuplicatesRed(int[] sudokuIntArray)
        {
            FieldColor[] fieldColorArray = new FieldColor[NumberOfSudokuFields];
            bool[] duplicateArray = GetDuplicatesArray(sudokuIntArray);

            for (int i = 0; i < duplicateArray.Length; i++)
            {
                fieldColorArray[i] = duplicateArray[i] ? FieldColor.Red : FieldColor.Black;
            }
            return fieldColorArray;
        }

        private FieldColor[] MakeAllFieldsGreen()
        {
            FieldColor[] fieldColorArray = new FieldColor[NumberOfSudokuFields];
            for (int i = 0; i < fieldColorArray.Length; i++)
            {
                fieldColorArray[i] = FieldColor.Green;
            }
            return fieldColorArray;
        }
        #endregion
    }
}