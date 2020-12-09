using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Calculator
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ICalculator calculator;

        //-------------------------
        private SudokuList sudokuList;

        private string sudokuString;
        //-------------------------

        private string result = string.Empty;
        public string Result
        {
            get
            {
                return result;
            }
            private set
            {
                if (result != value)
                {
                    result = value;
                    OnPropertyChanged(nameof(Result));
                }
            }
        }


        private string _field01 = string.Empty;

        public string Field01
        {
            get
            {
                return _field01;
            }
            private set
            {
                if (_field01 != value)
                {
                    _field01 = value;
                    OnPropertyChanged(nameof(Field01));
                }
            }
        }

        private string _field02 = string.Empty;

        public string Field02
        {
            get
            {
                return _field02;
            }
            private set
            {
                if (_field02 != value)
                {
                    _field02 = value;
                    OnPropertyChanged(nameof(Field03));
                }
            }
        }

        private string _field03 = string.Empty;

        public string Field03
        {
            get
            {
                return _field03;
            }
            private set
            {
                if (_field03 != value)
                {
                    _field03 = value;
                    OnPropertyChanged(nameof(Field03));
                }
            }
        }

        public MainPageViewModel(ICalculator calculator)
        {
            this.calculator = calculator;
            this.sudokuList = new SudokuList();
            Field01 = sudokuList[0].FieldValueString;
            Field02 = sudokuList[1].FieldValueString;
        }

        private ICommand _loadButtonCommand;
        public ICommand LoadButtonCommand
        {
            get
            {
                _loadButtonCommand = new Command<string>(Load);
                return _loadButtonCommand;
            }

        }

        private void Load(string commandString)
        {
            Field03 = commandString;
        }
    }
}
