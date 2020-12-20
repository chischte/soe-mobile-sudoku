using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using SudokuApp.SudokuProvider;
using SudokuApp.view;

namespace SudokuApp.Model
{
    public class SudokuManager : ISudokuManager
    {
        // The SudokuManager works internally with integer arrays
        // It gets string arrays from the view model an
        // It returns string array from the view model
        // From the sudoku parser it gets an integer array

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        const int NumberOfSudokuFields = 4;
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        private SudokuParser sudokuParser;

        public SudokuManager()
        {
            this.sudokuParser = new SudokuParser();
        }

        #region public methods -------------------------------------------------

        public string[] GetNewSudokuStringArray()
        {
            int[] sudokuIntArray = sudokuParser.GetSudokuArrayFromJson();
            return ConvertIntToStringArray(sudokuIntArray);
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
            FieldColor[] sudokuFieldColorArray = new FieldColor[NumberOfSudokuFields];

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
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //for (int i = 0; i < sudokuIntArray.Length; i++)
            for (int i = 0; i < 4; i++)
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
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
                duplicatesArray[j] = CheckFieldValueForDuplicate(sudokuIntArray[j], sudokuIntArray);
            }
            return duplicatesArray;
        }

        private bool CheckFieldValueForDuplicate(int currentValue, int[] intArray)
        {
            int duplicateCounter = 0;
            foreach (var fieldValue in intArray)
            {
                if (currentValue != 0 && currentValue == fieldValue)
                {
                    duplicateCounter++;
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