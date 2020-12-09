using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Calculator
{
    public class SudokuList : ObservableCollection<SudokuField>
    {
        public SudokuList() : base()
        {
            Add(new SudokuField(1, 99, "88"));
            Add(new SudokuField(2, 130, "99"));
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
