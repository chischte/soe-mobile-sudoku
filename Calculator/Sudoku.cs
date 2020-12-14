using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Text;

namespace Calculator
{
    public class SudokuManager
    {
        private SudokuList sudokulist;
        private SudokuParser sudokuParser;
        public SudokuManager()
        {
            this.sudokulist=new SudokuList();
            this.sudokuParser=new SudokuParser();
        }

        public int[] GetSudokuIntArray()
        {
            return sudokuParser.GetSudokuArrayFromJson();
        }

        public void CheckSudokuIntArray(int[] sudokuIntArray)
        {
            for (int i = 0; i < sudokuIntArray.Length; i++)
            {
                var loescher = sudokuIntArray[i];
            }

        }

        public void ParseJson()
        {
            SudokuParser sudokuParser = new SudokuParser();
            sudokuParser.GetSudokuArrayFromJson();
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
