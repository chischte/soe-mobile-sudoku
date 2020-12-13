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
        private readonly SudokuManager sudokuManager;

        public int NumberOfFields = 81;
        public string[] FieldIsEnabledArray { get; set; }
        public MainPageViewModel(ICalculator calculator)
        {
            this.sudokuManager = new SudokuManager();
            AssignValuesToFields();
            DisableFieldsWithFixedNumbers();
        }

        private void AssignValuesToFields()
        {
            var sudokuIntArray = sudokuManager.GetSudokuIntArray();
            Field01 = (sudokuIntArray[0] == 0) ? "" : sudokuIntArray[0].ToString();
            Field02 = (sudokuIntArray[1] == 0) ? "" : sudokuIntArray[1].ToString();
            Field03 = (sudokuIntArray[2] == 0) ? "" : sudokuIntArray[2].ToString();
            Field04 = (sudokuIntArray[3] == 0) ? "" : sudokuIntArray[3].ToString();
        }

        private int[] GetIntArrayFromFields()
        {
            int[] intArrayFromFields = new int[NumberOfFields];
            intArrayFromFields[0] = (Field01.Equals("") ? 0 : int.Parse(Field01));
            intArrayFromFields[1] = (Field02.Equals("") ? 0 : int.Parse(Field02));
            intArrayFromFields[2] = (Field03.Equals("") ? 0 : int.Parse(Field03));
            intArrayFromFields[3] = (Field04.Equals("") ? 0 : int.Parse(Field04));

            return intArrayFromFields;
        }
        private void DisableFieldsWithFixedNumbers()
        {
            var sudokuIntArray = sudokuManager.GetSudokuIntArray();
            FieldIsEnabledArray = new string[NumberOfFields];
            for (int i = 0; i < sudokuIntArray.Length; i++)
            {
                FieldIsEnabledArray[i] = (sudokuIntArray[i] == 0) ? "true" : "false";
            }
        }

        #region INotifyFields

        private string _field01 = string.Empty;
        public string Field01
        {
            get => _field01;
            set
            {
                if (_field01 == value) return;
                _field01 = value;
                OnPropertyChanged(nameof(Field01));
            }
        }

        private string _field02 = string.Empty;
        public string Field02
        {
            get
            {
                return _field02;
            }
            set
            {
                if (_field02 != value)
                {
                    _field02 = value;
                    OnPropertyChanged(nameof(Field02));
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
            set
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
                if (_field04 != value)
                {
                    _field04 = value;
                    OnPropertyChanged(nameof(Field04));
                }
            }
        }
        #endregion

        #region ICommandButtons

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

        private ICommand _checkButtonCommand;
        public ICommand CheckButtonCommand
        {
            get
            {
                _checkButtonCommand = new Command<string>(Check);
                return _checkButtonCommand;
            }

        }
        private void Check(string commandString)
        {
            sudokuManager.CheckSudokuIntArray(GetIntArrayFromFields());
        }
        #endregion
    }
}
