using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SudokuApp
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ISudokuManager sudokuManager;

        public int NumberOfFields = 81;
        public MainPageViewModel(ISudokuManager sudokuManager)
        {
            this.sudokuManager = sudokuManager;
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
            intArray = RemoveInvalidEntries(intArray);
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
            IsEnabled01 = (sudokuIntArray[0] == 0) ? "true" : "false";
            IsEnabled02 = (sudokuIntArray[1] == 0) ? "true" : "false";
            IsEnabled03 = (sudokuIntArray[2] == 0) ? "true" : "false";
            IsEnabled04 = (sudokuIntArray[3] == 0) ? "true" : "false";
        }

        private void MakeDuplicatesRed(bool[] duplicatesArray)
        {
            FieldColor01 = (duplicatesArray[0] == true) ? "red" : "black";
            FieldColor02 = (duplicatesArray[1] == true) ? "red" : "black";
            FieldColor03 = (duplicatesArray[2] == true) ? "red" : "black";
            FieldColor04 = (duplicatesArray[3] == true) ? "red" : "black";
        }

        #region INotifyFieldValues

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

        #region INotifyFieldEnabled

        private string _isEnabled01 = string.Empty;
        public string IsEnabled01
        {
            get => _isEnabled01;
            set
            {
                if (_isEnabled01 == value) return;
                _isEnabled01 = value;
                OnPropertyChanged(nameof(IsEnabled01));
            }
        }

        private string _isEnabled02 = string.Empty;
        public string IsEnabled02
        {
            get
            {
                return _isEnabled02;
            }
            set
            {
                if (_isEnabled02 != value)
                {
                    _isEnabled02 = value;
                    OnPropertyChanged(nameof(IsEnabled02));
                }
            }
        }

        private string _isEnabled03 = string.Empty;
        public string IsEnabled03
        {
            get
            {
                return _isEnabled03;
            }
            set
            {
                if (_isEnabled03 != value)
                {
                    _isEnabled03 = value;
                    OnPropertyChanged(nameof(IsEnabled03));
                }
            }
        }
        private string _isEnabled04 = string.Empty;
        public string IsEnabled04
        {
            get
            {
                return _isEnabled04;
            }
            set
            {
                if (_isEnabled04 != value)
                {
                    _isEnabled04 = value;
                    OnPropertyChanged(nameof(IsEnabled04));
                }
            }
        }
        #endregion

        #region INotifyFieldColor

        private string _fieldColor01 = "black";
        public string FieldColor01
        {
            get => _fieldColor01;
            set
            {
                if (_fieldColor01 == value) return;
                _fieldColor01 = value;
                OnPropertyChanged(nameof(FieldColor01));
            }
        }

        private string _fieldColor02 = "black";
        public string FieldColor02
        {
            get
            {
                return _fieldColor02;
            }
            set
            {
                if (_fieldColor02 != value)
                {
                    _fieldColor02 = value;
                    OnPropertyChanged(nameof(FieldColor02));
                }
            }
        }

        private string _fieldColor03 = "black";
        public string FieldColor03
        {
            get
            {
                return _fieldColor03;
            }
            set
            {
                if (_fieldColor03 != value)
                {
                    _fieldColor03 = value;
                    OnPropertyChanged(nameof(FieldColor03));
                }
            }
        }
        private string _fieldColor04 = "black";
        public string FieldColor04
        {
            get
            {
                return _fieldColor04;
            }
            set
            {
                if (_fieldColor04 != value)
                {
                    _fieldColor04 = value;
                    OnPropertyChanged(nameof(FieldColor04));
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
            DisableFieldsWithFixedNumbers();
            AssignValuesToFields(sudokuManager.GetSudokuIntArray());

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
            AssignValuesToFields(valuesFromFields); // Invalid entries have been removed
            bool[] duplicatesArray = sudokuManager.GetDuplicatesArray(valuesFromFields);
            MakeDuplicatesRed(duplicatesArray);
        }


        #endregion
    }
}
