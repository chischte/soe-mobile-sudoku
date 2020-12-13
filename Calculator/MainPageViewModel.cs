using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Input;
using Xamarin.Forms;

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
            AssignValuesToFields(sudokuManager.GetSudokuIntArray());
            DisableFieldsWithFixedNumbers();
        }

        private void AssignValuesToFields(int[] sudokuIntArray)
        {
            Field01 = (sudokuIntArray[0] == 0) ? "" : sudokuIntArray[0].ToString();
            Field02 = (sudokuIntArray[1] == 0) ? "" : sudokuIntArray[1].ToString();
            Field03 = (sudokuIntArray[2] == 0) ? "" : sudokuIntArray[2].ToString();
            Field04 = (sudokuIntArray[3] == 0) ? "" : sudokuIntArray[3].ToString();
        }

        private string[] GetStringArrayFromFields()
        {
            string[] stringArrayFromFields = new string[NumberOfFields];
            stringArrayFromFields[0] = Field01;
            stringArrayFromFields[1] = Field02;
            stringArrayFromFields[2] = Field03;
            stringArrayFromFields[3] = Field04;

            return stringArrayFromFields;
        }

        private int[] GetIntArrayFromFields()
        {
            int[] intArray = new int[NumberOfFields];
            string[] stringArray = GetStringArrayFromFields();

            for (int i = 0; i < stringArray.Length; i++)
            {
                int.TryParse(stringArray[i], out intArray[i]);
            }
            return intArray;
        }

        private int[] RemoveInvalidEntries(int[] intArray)
        {
            int[] validFieldValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < intArray.Length; i++)
            {
                if (!validFieldValues.Contains(intArray[i]))
                {
                    intArray[i] = 0;
                }
            }
            return intArray;
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
                _checkButtonCommand = new Command<string>(CheckAndRefresh);
                return _checkButtonCommand;
            }
        }
        private void CheckAndRefresh(string commandString)
        {
            int[] valuesFromFields = GetIntArrayFromFields();
            valuesFromFields = RemoveInvalidEntries(valuesFromFields);
            AssignValuesToFields(valuesFromFields);
            sudokuManager.CheckSudokuIntArray(valuesFromFields);
        }
        #endregion
    }
}
