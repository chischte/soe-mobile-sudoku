using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;

namespace Calculator
{
    public class SudokuManager
    {
       const int SudokuNumberOfFields = 81; 
        private SudokuList sudokulist;
        private SudokuParser sudokuParser;
        public SudokuManager()
        {
            this.sudokulist = new SudokuList();
            this.sudokuParser = new SudokuParser();
        }

        public int[] GetSudokuIntArray()
        {
            return sudokuParser.GetSudokuArrayFromJson();
        }

        public bool[] GetDuplicatesArray(int[] sudokuIntArray)
        {
            bool[] duplicatesArray = new bool[SudokuNumberOfFields];

            for (int j = 0; j < sudokuIntArray.Length; j++)
            {
                duplicatesArray[j] = CheckForDuplicate(sudokuIntArray[j], sudokuIntArray);
            }

            return duplicatesArray;
        }

        private bool CheckForDuplicate(int value, int[] intArray)
        {
            int duplicateCounter = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                if (value !=0 && value == intArray[i])
                {
                    duplicateCounter++;
                }
            }
            return duplicateCounter > 1;
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
