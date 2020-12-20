using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using SudokuApp.SudokuProvider;
using SudokuApp.view;

namespace SudokuApp.Model
{
    public class SudokuManager : ISudokuManager
    {
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        const int SudokuNumberOfFields = 4;
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private SudokuParser sudokuParser;
        public SudokuManager()
        {
            this.sudokuParser = new SudokuParser();
        }

        public int[] GetSudokuIntArray()
        {
            return sudokuParser.GetSudokuArrayFromJson();
        }


        // if number of empty fields = 0
        // if number of duplicates = 0
        //-make all fields green

        public FieldColor[] GetFieldColorArray(int[] sudokuIntArray)
        {
            FieldColor[] sudokuFieldColorArray = new FieldColor[SudokuNumberOfFields];
            bool sudokuHasEmptyFields = CheckForEmptyFields(sudokuIntArray);
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

        private bool CheckSudokuForDuplicates(int[] sudokuIntArray)
        {
            bool[] duplicatesArray = GetDuplicatesArray(sudokuIntArray);
            bool sudokuHasDuplicates = CheckDuplicateArrayForDuplicates(duplicatesArray);
            return sudokuHasDuplicates;
        }

        private bool[] GetDuplicatesArray(int[] sudokuIntArray)
        {
            bool[] duplicatesArray = new bool[SudokuNumberOfFields];

            for (int j = 0; j < sudokuIntArray.Length; j++)
            {
                duplicatesArray[j] = CheckFieldValueForDuplicate(sudokuIntArray[j], sudokuIntArray);
            }
            return duplicatesArray;
        }
        private bool CheckFieldValueForDuplicate(int value, int[] intArray)
        {
            int duplicateCounter = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (value != 0 && value == intArray[i])
                {
                    duplicateCounter++;
                }
            }
            return duplicateCounter > 1;
        }

        private bool CheckForEmptyFields(int[] sudokuIntArray)
        {
            bool hasEmptyFields = false;
            for (int i = 0; i < sudokuIntArray.Length; i++)
            {
                if (sudokuIntArray[i] == 0)
                {
                    hasEmptyFields = true;
                }
            }
            return hasEmptyFields;
        }

        private bool CheckDuplicateArrayForDuplicates(bool[] duplicatesArray)
        {
            bool duplicateArrayHasDuplicates = false;
            for (int i = 0; i < duplicatesArray.Length; i++)
            {
                if (duplicatesArray[i])
                {
                    duplicateArrayHasDuplicates = true;
                }
            }
            return duplicateArrayHasDuplicates;
        }

        private FieldColor[] MakeDuplicatesRed(int[] sudokuIntArray)
        {
            FieldColor[] fieldColorArray = new FieldColor[SudokuNumberOfFields];
            bool[] duplicateArray = GetDuplicatesArray(sudokuIntArray);

            for (int i = 0; i < duplicateArray.Length; i++)
            {
                fieldColorArray[i] = duplicateArray[i] ? FieldColor.Red : FieldColor.Black;
            }
            return fieldColorArray;
        }

        private FieldColor[] MakeAllFieldsGreen()
        {
            FieldColor[] fieldColorArray = new FieldColor[SudokuNumberOfFields];
            for (int i = 0; i < fieldColorArray.Length; i++)
            {
                fieldColorArray[i] = FieldColor.Green;
            }
            return fieldColorArray;
        }
    }

    public class SudokuList : ObservableCollection<SudokuField>
    {
        public SudokuList() : base()
        {
            Add(new SudokuField(1, 99, "88"));
            Add(new SudokuField(2, 130, "99"));
            Add(new SudokuField(3, 130, "99"));
            Add(new SudokuField(4, 0, "99"));
        }
    }

    public class SudokuField
    {
        private int fieldNumber;
        private int fieldValue;
        private string fieldValueString;

        public SudokuField(int fieldNumber, int fieldValue, string fieldValueString)
        {
            this.fieldNumber = fieldNumber;
            this.fieldValue = fieldValue;
            this.fieldValueString = fieldValueString;
        }

        public int FieldNumber
        {
            get { return fieldNumber; }
            set { fieldNumber = value; }
        }

        public int FieldValue
        {
            get { return fieldValue; }
            set { fieldValue = value; }
        }

        public string FieldValueString
        {
            get { return fieldValueString; }
            set { fieldValueString = value; }
        }
    }
}
