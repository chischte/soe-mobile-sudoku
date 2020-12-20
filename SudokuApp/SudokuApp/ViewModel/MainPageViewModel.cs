using System;
using System.Linq;
using System.Windows.Input;
using SudokuApp.Model;
using SudokuApp.view;
using Xamarin.Forms;

namespace SudokuApp.ViewModel
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly ISudokuManager sudokuManager;

        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        const int NumberOfSudokuFields = 4;
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public MainPageViewModel(ISudokuManager sudokuManager)
        {
            this.sudokuManager = sudokuManager;
        }

        private void AssignValuesToFields(string[] sudokuStringArray)
        {
            Field01 = sudokuStringArray[0];
            Field02 = sudokuStringArray[1];
            Field03 = sudokuStringArray[2];
            Field04 = sudokuStringArray[3];
            //Field04 = (sudokuStringArray[3] == 0) ? "" : sudokuStringArray[3].ToString();
        }

        private string[] GetStringArrayFromFields()
        {
            string[] stringArrayFromFields = new string[NumberOfSudokuFields];
            stringArrayFromFields[0] = Field01;
            stringArrayFromFields[1] = Field02;
            stringArrayFromFields[2] = Field03;
            stringArrayFromFields[3] = Field04;

            return stringArrayFromFields;
        }

        private void DisableFieldsWithFixedNumbers(string[] sudokuStringArray)
        {
            IsEnabled01 = String.IsNullOrEmpty(sudokuStringArray[0]) ? "true" : "false";
            IsEnabled02 = String.IsNullOrEmpty(sudokuStringArray[1]) ? "true" : "false";
            IsEnabled03 = String.IsNullOrEmpty(sudokuStringArray[2]) ? "true" : "false";
            IsEnabled04 = String.IsNullOrEmpty(sudokuStringArray[3]) ? "true" : "false";
            //IsEnabled04 = (sudokuStringArray[3] == "") ? "true" : "false";
        }

        private void SetFieldColors(FieldColor[] fieldColorArray)
        {
            FieldColor01 = Enum.GetName(typeof(FieldColor), fieldColorArray[0]);
            FieldColor02 = Enum.GetName(typeof(FieldColor), fieldColorArray[1]);
            FieldColor03 = Enum.GetName(typeof(FieldColor), fieldColorArray[2]);
            FieldColor04 = Enum.GetName(typeof(FieldColor), fieldColorArray[3]);
            //FieldColor04 = (fieldColorArray[3] == true) ? "red" : "black";
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
            string[] sudokuStringArray = sudokuManager.GetNewSudokuStringArray();
            DisableFieldsWithFixedNumbers(sudokuStringArray);
            AssignValuesToFields(sudokuStringArray);
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
            
            string[] checkedFieldValues = sudokuManager.GetCheckedStringArray(GetStringArrayFromFields());
            AssignValuesToFields(checkedFieldValues); // Invalid entries have been removed
            FieldColor[] fieldColorArray = sudokuManager.GetFieldColorArray(checkedFieldValues);
            SetFieldColors(fieldColorArray);
        }
        #endregion
    }
}
