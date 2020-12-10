using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;
// https://www.c-sharpcorner.com/article/login-form-in-xamarin-forms-for-biggner-using-mvvm-pattern
// https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-5.0
namespace Calculator
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ICalculator calculator;

        //-------------------------
        private SudokuList sudokuList;

        private string sudokuString;
        //-------------------------


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
        private string _field04 = string.Empty;
        public string Field04
        {
            get
            {
                return _field04;
            }
            set
            {
                _field04 = value;
                OnPropertyChanged(nameof(Field04));
                Field03 = "333";

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged(nameof(Email));
                Field03 = "444";
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
