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

        const int NumberOfSudokuFields = 81;
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
            Field05 = sudokuStringArray[4];
            Field06 = sudokuStringArray[5];
            Field07 = sudokuStringArray[6];
            Field08 = sudokuStringArray[7];
            Field09 = sudokuStringArray[8];
            Field10 = sudokuStringArray[9];
            Field11 = sudokuStringArray[10];
            Field12 = sudokuStringArray[11];
            Field13 = sudokuStringArray[12];
            Field14 = sudokuStringArray[13];
            Field15 = sudokuStringArray[14];
            Field16 = sudokuStringArray[15];
            Field17 = sudokuStringArray[16];
            Field18 = sudokuStringArray[17];
            Field19 = sudokuStringArray[18];
            Field20 = sudokuStringArray[19];
            Field21 = sudokuStringArray[20];
            Field22 = sudokuStringArray[21];
            Field23 = sudokuStringArray[22];
            Field24 = sudokuStringArray[23];
            Field25 = sudokuStringArray[24];
            Field26 = sudokuStringArray[25];
            Field27 = sudokuStringArray[26];
            Field28 = sudokuStringArray[27];
            Field29 = sudokuStringArray[28];
            Field30 = sudokuStringArray[29];
            Field31 = sudokuStringArray[30];
            Field32 = sudokuStringArray[31];
            Field33 = sudokuStringArray[32];
            Field34 = sudokuStringArray[33];
            Field35 = sudokuStringArray[34];
            Field36 = sudokuStringArray[35];
            Field37 = sudokuStringArray[36];
            Field38 = sudokuStringArray[37];
            Field39 = sudokuStringArray[38];
            Field40 = sudokuStringArray[39];
            Field41 = sudokuStringArray[40];
            Field42 = sudokuStringArray[41];
            Field43 = sudokuStringArray[42];
            Field44 = sudokuStringArray[43];
            Field45 = sudokuStringArray[44];
            Field46 = sudokuStringArray[45];
            Field47 = sudokuStringArray[46];
            Field48 = sudokuStringArray[47];
            Field49 = sudokuStringArray[48];
            Field50 = sudokuStringArray[49];
            Field51 = sudokuStringArray[50];
            Field52 = sudokuStringArray[51];
            Field53 = sudokuStringArray[52];
            Field54 = sudokuStringArray[53];
            Field55 = sudokuStringArray[54];
            Field56 = sudokuStringArray[55];
            Field57 = sudokuStringArray[56];
            Field58 = sudokuStringArray[57];
            Field59 = sudokuStringArray[58];
            Field60 = sudokuStringArray[59];
            Field61 = sudokuStringArray[60];
            Field62 = sudokuStringArray[61];
            Field63 = sudokuStringArray[62];
            Field64 = sudokuStringArray[63];
            Field65 = sudokuStringArray[64];
            Field66 = sudokuStringArray[65];
            Field67 = sudokuStringArray[66];
            Field68 = sudokuStringArray[67];
            Field69 = sudokuStringArray[68];
            Field70 = sudokuStringArray[69];
            Field71 = sudokuStringArray[70];
            Field72 = sudokuStringArray[71];
            Field73 = sudokuStringArray[72];
            Field74 = sudokuStringArray[73];
            Field75 = sudokuStringArray[74];
            Field76 = sudokuStringArray[75];
            Field77 = sudokuStringArray[76];
            Field78 = sudokuStringArray[77];
            Field79 = sudokuStringArray[78];
            Field80 = sudokuStringArray[79];
            Field81 = sudokuStringArray[80];
        }

        private string[] GetStringArrayFromFields()
        {
            string[] stringArrayFromFields = new string[NumberOfSudokuFields];
            stringArrayFromFields[0] = Field01;
            stringArrayFromFields[1] = Field02;
            stringArrayFromFields[2] = Field03;
            stringArrayFromFields[3] = Field04;
            stringArrayFromFields[4] = Field05;
            stringArrayFromFields[5] = Field06;
            stringArrayFromFields[6] = Field07;
            stringArrayFromFields[7] = Field08;
            stringArrayFromFields[8] = Field09;
            stringArrayFromFields[9] = Field10;
            stringArrayFromFields[10] = Field11;
            stringArrayFromFields[11] = Field12;
            stringArrayFromFields[12] = Field13;
            stringArrayFromFields[13] = Field14;
            stringArrayFromFields[14] = Field15;
            stringArrayFromFields[15] = Field16;
            stringArrayFromFields[16] = Field17;
            stringArrayFromFields[17] = Field18;
            stringArrayFromFields[18] = Field19;
            stringArrayFromFields[19] = Field20;
            stringArrayFromFields[20] = Field21;
            stringArrayFromFields[21] = Field22;
            stringArrayFromFields[22] = Field23;
            stringArrayFromFields[23] = Field24;
            stringArrayFromFields[24] = Field25;
            stringArrayFromFields[25] = Field26;
            stringArrayFromFields[26] = Field27;
            stringArrayFromFields[27] = Field28;
            stringArrayFromFields[28] = Field29;
            stringArrayFromFields[29] = Field30;
            stringArrayFromFields[30] = Field31;
            stringArrayFromFields[31] = Field32;
            stringArrayFromFields[32] = Field33;
            stringArrayFromFields[33] = Field34;
            stringArrayFromFields[34] = Field35;
            stringArrayFromFields[35] = Field36;
            stringArrayFromFields[36] = Field37;
            stringArrayFromFields[37] = Field38;
            stringArrayFromFields[38] = Field39;
            stringArrayFromFields[39] = Field40;
            stringArrayFromFields[40] = Field41;
            stringArrayFromFields[41] = Field42;
            stringArrayFromFields[42] = Field43;
            stringArrayFromFields[43] = Field44;
            stringArrayFromFields[44] = Field45;
            stringArrayFromFields[45] = Field46;
            stringArrayFromFields[46] = Field47;
            stringArrayFromFields[47] = Field48;
            stringArrayFromFields[48] = Field49;
            stringArrayFromFields[49] = Field50;
            stringArrayFromFields[50] = Field51;
            stringArrayFromFields[51] = Field52;
            stringArrayFromFields[52] = Field53;
            stringArrayFromFields[53] = Field54;
            stringArrayFromFields[54] = Field55;
            stringArrayFromFields[55] = Field56;
            stringArrayFromFields[56] = Field57;
            stringArrayFromFields[57] = Field58;
            stringArrayFromFields[58] = Field59;
            stringArrayFromFields[59] = Field60;
            stringArrayFromFields[60] = Field61;
            stringArrayFromFields[61] = Field62;
            stringArrayFromFields[62] = Field63;
            stringArrayFromFields[63] = Field64;
            stringArrayFromFields[64] = Field65;
            stringArrayFromFields[65] = Field66;
            stringArrayFromFields[66] = Field67;
            stringArrayFromFields[67] = Field68;
            stringArrayFromFields[68] = Field69;
            stringArrayFromFields[69] = Field70;
            stringArrayFromFields[70] = Field71;
            stringArrayFromFields[71] = Field72;
            stringArrayFromFields[72] = Field73;
            stringArrayFromFields[73] = Field74;
            stringArrayFromFields[74] = Field75;
            stringArrayFromFields[75] = Field76;
            stringArrayFromFields[76] = Field77;
            stringArrayFromFields[77] = Field78;
            stringArrayFromFields[78] = Field79;
            stringArrayFromFields[79] = Field80;
            stringArrayFromFields[80] = Field81;
            return stringArrayFromFields;
        }

        private void DisableFieldsWithFixedNumbers(string[] sudokuStringArray)
        {
            IsEnabled01 = String.IsNullOrEmpty(sudokuStringArray[0]) ? "true" : "false";
            IsEnabled02 = String.IsNullOrEmpty(sudokuStringArray[1]) ? "true" : "false";
            IsEnabled03 = String.IsNullOrEmpty(sudokuStringArray[2]) ? "true" : "false";
            IsEnabled04 = String.IsNullOrEmpty(sudokuStringArray[3]) ? "true" : "false";
            IsEnabled05 = String.IsNullOrEmpty(sudokuStringArray[4]) ? "true" : "false";
            IsEnabled06 = String.IsNullOrEmpty(sudokuStringArray[5]) ? "true" : "false";
            IsEnabled07 = String.IsNullOrEmpty(sudokuStringArray[6]) ? "true" : "false";
            IsEnabled08 = String.IsNullOrEmpty(sudokuStringArray[7]) ? "true" : "false";
            IsEnabled09 = String.IsNullOrEmpty(sudokuStringArray[8]) ? "true" : "false";
            IsEnabled10 = String.IsNullOrEmpty(sudokuStringArray[9]) ? "true" : "false";
            IsEnabled11 = String.IsNullOrEmpty(sudokuStringArray[10]) ? "true" : "false";
            IsEnabled12 = String.IsNullOrEmpty(sudokuStringArray[11]) ? "true" : "false";
            IsEnabled13 = String.IsNullOrEmpty(sudokuStringArray[12]) ? "true" : "false";
            IsEnabled14 = String.IsNullOrEmpty(sudokuStringArray[13]) ? "true" : "false";
            IsEnabled15 = String.IsNullOrEmpty(sudokuStringArray[14]) ? "true" : "false";
            IsEnabled16 = String.IsNullOrEmpty(sudokuStringArray[15]) ? "true" : "false";
            IsEnabled17 = String.IsNullOrEmpty(sudokuStringArray[16]) ? "true" : "false";
            IsEnabled18 = String.IsNullOrEmpty(sudokuStringArray[17]) ? "true" : "false";
            IsEnabled19 = String.IsNullOrEmpty(sudokuStringArray[18]) ? "true" : "false";
            IsEnabled20 = String.IsNullOrEmpty(sudokuStringArray[19]) ? "true" : "false";
            IsEnabled21 = String.IsNullOrEmpty(sudokuStringArray[20]) ? "true" : "false";
            IsEnabled22 = String.IsNullOrEmpty(sudokuStringArray[21]) ? "true" : "false";
            IsEnabled23 = String.IsNullOrEmpty(sudokuStringArray[22]) ? "true" : "false";
            IsEnabled24 = String.IsNullOrEmpty(sudokuStringArray[23]) ? "true" : "false";
            IsEnabled25 = String.IsNullOrEmpty(sudokuStringArray[24]) ? "true" : "false";
            IsEnabled26 = String.IsNullOrEmpty(sudokuStringArray[25]) ? "true" : "false";
            IsEnabled27 = String.IsNullOrEmpty(sudokuStringArray[26]) ? "true" : "false";
            IsEnabled28 = String.IsNullOrEmpty(sudokuStringArray[27]) ? "true" : "false";
            IsEnabled29 = String.IsNullOrEmpty(sudokuStringArray[28]) ? "true" : "false";
            IsEnabled30 = String.IsNullOrEmpty(sudokuStringArray[29]) ? "true" : "false";
            IsEnabled31 = String.IsNullOrEmpty(sudokuStringArray[30]) ? "true" : "false";
            IsEnabled32 = String.IsNullOrEmpty(sudokuStringArray[31]) ? "true" : "false";
            IsEnabled33 = String.IsNullOrEmpty(sudokuStringArray[32]) ? "true" : "false";
            IsEnabled34 = String.IsNullOrEmpty(sudokuStringArray[33]) ? "true" : "false";
            IsEnabled35 = String.IsNullOrEmpty(sudokuStringArray[34]) ? "true" : "false";
            IsEnabled36 = String.IsNullOrEmpty(sudokuStringArray[35]) ? "true" : "false";
            IsEnabled37 = String.IsNullOrEmpty(sudokuStringArray[36]) ? "true" : "false";
            IsEnabled38 = String.IsNullOrEmpty(sudokuStringArray[37]) ? "true" : "false";
            IsEnabled39 = String.IsNullOrEmpty(sudokuStringArray[38]) ? "true" : "false";
            IsEnabled40 = String.IsNullOrEmpty(sudokuStringArray[39]) ? "true" : "false";
            IsEnabled41 = String.IsNullOrEmpty(sudokuStringArray[40]) ? "true" : "false";
            IsEnabled42 = String.IsNullOrEmpty(sudokuStringArray[41]) ? "true" : "false";
            IsEnabled43 = String.IsNullOrEmpty(sudokuStringArray[42]) ? "true" : "false";
            IsEnabled44 = String.IsNullOrEmpty(sudokuStringArray[43]) ? "true" : "false";
            IsEnabled45 = String.IsNullOrEmpty(sudokuStringArray[44]) ? "true" : "false";
            IsEnabled46 = String.IsNullOrEmpty(sudokuStringArray[45]) ? "true" : "false";
            IsEnabled47 = String.IsNullOrEmpty(sudokuStringArray[46]) ? "true" : "false";
            IsEnabled48 = String.IsNullOrEmpty(sudokuStringArray[47]) ? "true" : "false";
            IsEnabled49 = String.IsNullOrEmpty(sudokuStringArray[48]) ? "true" : "false";
            IsEnabled50 = String.IsNullOrEmpty(sudokuStringArray[49]) ? "true" : "false";
            IsEnabled51 = String.IsNullOrEmpty(sudokuStringArray[50]) ? "true" : "false";
            IsEnabled52 = String.IsNullOrEmpty(sudokuStringArray[51]) ? "true" : "false";
            IsEnabled53 = String.IsNullOrEmpty(sudokuStringArray[52]) ? "true" : "false";
            IsEnabled54 = String.IsNullOrEmpty(sudokuStringArray[53]) ? "true" : "false";
            IsEnabled55 = String.IsNullOrEmpty(sudokuStringArray[54]) ? "true" : "false";
            IsEnabled56 = String.IsNullOrEmpty(sudokuStringArray[55]) ? "true" : "false";
            IsEnabled57 = String.IsNullOrEmpty(sudokuStringArray[56]) ? "true" : "false";
            IsEnabled58 = String.IsNullOrEmpty(sudokuStringArray[57]) ? "true" : "false";
            IsEnabled59 = String.IsNullOrEmpty(sudokuStringArray[58]) ? "true" : "false";
            IsEnabled60 = String.IsNullOrEmpty(sudokuStringArray[59]) ? "true" : "false";
            IsEnabled61 = String.IsNullOrEmpty(sudokuStringArray[60]) ? "true" : "false";
            IsEnabled62 = String.IsNullOrEmpty(sudokuStringArray[61]) ? "true" : "false";
            IsEnabled63 = String.IsNullOrEmpty(sudokuStringArray[62]) ? "true" : "false";
            IsEnabled64 = String.IsNullOrEmpty(sudokuStringArray[63]) ? "true" : "false";
            IsEnabled65 = String.IsNullOrEmpty(sudokuStringArray[64]) ? "true" : "false";
            IsEnabled66 = String.IsNullOrEmpty(sudokuStringArray[65]) ? "true" : "false";
            IsEnabled67 = String.IsNullOrEmpty(sudokuStringArray[66]) ? "true" : "false";
            IsEnabled68 = String.IsNullOrEmpty(sudokuStringArray[67]) ? "true" : "false";
            IsEnabled69 = String.IsNullOrEmpty(sudokuStringArray[68]) ? "true" : "false";
            IsEnabled70 = String.IsNullOrEmpty(sudokuStringArray[69]) ? "true" : "false";
            IsEnabled71 = String.IsNullOrEmpty(sudokuStringArray[70]) ? "true" : "false";
            IsEnabled72 = String.IsNullOrEmpty(sudokuStringArray[71]) ? "true" : "false";
            IsEnabled73 = String.IsNullOrEmpty(sudokuStringArray[72]) ? "true" : "false";
            IsEnabled74 = String.IsNullOrEmpty(sudokuStringArray[73]) ? "true" : "false";
            IsEnabled75 = String.IsNullOrEmpty(sudokuStringArray[74]) ? "true" : "false";
            IsEnabled76 = String.IsNullOrEmpty(sudokuStringArray[75]) ? "true" : "false";
            IsEnabled77 = String.IsNullOrEmpty(sudokuStringArray[76]) ? "true" : "false";
            IsEnabled78 = String.IsNullOrEmpty(sudokuStringArray[77]) ? "true" : "false";
            IsEnabled79 = String.IsNullOrEmpty(sudokuStringArray[78]) ? "true" : "false";
            IsEnabled80 = String.IsNullOrEmpty(sudokuStringArray[79]) ? "true" : "false";
            IsEnabled81 = String.IsNullOrEmpty(sudokuStringArray[80]) ? "true" : "false";
        }

        private void SetFieldColors(FieldColor[] fieldColorArray)
        {
            FieldColor01 = Enum.GetName(typeof(FieldColor), fieldColorArray[0]);
            FieldColor02 = Enum.GetName(typeof(FieldColor), fieldColorArray[1]);
            FieldColor03 = Enum.GetName(typeof(FieldColor), fieldColorArray[2]);
            FieldColor04 = Enum.GetName(typeof(FieldColor), fieldColorArray[3]);
            FieldColor05 = Enum.GetName(typeof(FieldColor), fieldColorArray[4]);
            FieldColor06 = Enum.GetName(typeof(FieldColor), fieldColorArray[5]);
            FieldColor07 = Enum.GetName(typeof(FieldColor), fieldColorArray[6]);
            FieldColor08 = Enum.GetName(typeof(FieldColor), fieldColorArray[7]);
            FieldColor09 = Enum.GetName(typeof(FieldColor), fieldColorArray[8]);
            FieldColor10 = Enum.GetName(typeof(FieldColor), fieldColorArray[9]);
            FieldColor11 = Enum.GetName(typeof(FieldColor), fieldColorArray[10]);
            FieldColor12 = Enum.GetName(typeof(FieldColor), fieldColorArray[11]);
            FieldColor13 = Enum.GetName(typeof(FieldColor), fieldColorArray[12]);
            FieldColor14 = Enum.GetName(typeof(FieldColor), fieldColorArray[13]);
            FieldColor15 = Enum.GetName(typeof(FieldColor), fieldColorArray[14]);
            FieldColor16 = Enum.GetName(typeof(FieldColor), fieldColorArray[15]);
            FieldColor17 = Enum.GetName(typeof(FieldColor), fieldColorArray[16]);
            FieldColor18 = Enum.GetName(typeof(FieldColor), fieldColorArray[17]);
            FieldColor19 = Enum.GetName(typeof(FieldColor), fieldColorArray[18]);
            FieldColor20 = Enum.GetName(typeof(FieldColor), fieldColorArray[19]);
            FieldColor21 = Enum.GetName(typeof(FieldColor), fieldColorArray[20]);
            FieldColor22 = Enum.GetName(typeof(FieldColor), fieldColorArray[21]);
            FieldColor23 = Enum.GetName(typeof(FieldColor), fieldColorArray[22]);
            FieldColor24 = Enum.GetName(typeof(FieldColor), fieldColorArray[23]);
            FieldColor25 = Enum.GetName(typeof(FieldColor), fieldColorArray[24]);
            FieldColor26 = Enum.GetName(typeof(FieldColor), fieldColorArray[25]);
            FieldColor27 = Enum.GetName(typeof(FieldColor), fieldColorArray[26]);
            FieldColor28 = Enum.GetName(typeof(FieldColor), fieldColorArray[27]);
            FieldColor29 = Enum.GetName(typeof(FieldColor), fieldColorArray[28]);
            FieldColor30 = Enum.GetName(typeof(FieldColor), fieldColorArray[29]);
            FieldColor31 = Enum.GetName(typeof(FieldColor), fieldColorArray[30]);
            FieldColor32 = Enum.GetName(typeof(FieldColor), fieldColorArray[31]);
            FieldColor33 = Enum.GetName(typeof(FieldColor), fieldColorArray[32]);
            FieldColor34 = Enum.GetName(typeof(FieldColor), fieldColorArray[33]);
            FieldColor35 = Enum.GetName(typeof(FieldColor), fieldColorArray[34]);
            FieldColor36 = Enum.GetName(typeof(FieldColor), fieldColorArray[35]);
            FieldColor37 = Enum.GetName(typeof(FieldColor), fieldColorArray[36]);
            FieldColor38 = Enum.GetName(typeof(FieldColor), fieldColorArray[37]);
            FieldColor39 = Enum.GetName(typeof(FieldColor), fieldColorArray[38]);
            FieldColor40 = Enum.GetName(typeof(FieldColor), fieldColorArray[39]);
            FieldColor41 = Enum.GetName(typeof(FieldColor), fieldColorArray[40]);
            FieldColor42 = Enum.GetName(typeof(FieldColor), fieldColorArray[41]);
            FieldColor43 = Enum.GetName(typeof(FieldColor), fieldColorArray[42]);
            FieldColor44 = Enum.GetName(typeof(FieldColor), fieldColorArray[43]);
            FieldColor45 = Enum.GetName(typeof(FieldColor), fieldColorArray[44]);
            FieldColor46 = Enum.GetName(typeof(FieldColor), fieldColorArray[45]);
            FieldColor47 = Enum.GetName(typeof(FieldColor), fieldColorArray[46]);
            FieldColor48 = Enum.GetName(typeof(FieldColor), fieldColorArray[47]);
            FieldColor49 = Enum.GetName(typeof(FieldColor), fieldColorArray[48]);
            FieldColor50 = Enum.GetName(typeof(FieldColor), fieldColorArray[49]);
            FieldColor51 = Enum.GetName(typeof(FieldColor), fieldColorArray[50]);
            FieldColor52 = Enum.GetName(typeof(FieldColor), fieldColorArray[51]);
            FieldColor53 = Enum.GetName(typeof(FieldColor), fieldColorArray[52]);
            FieldColor54 = Enum.GetName(typeof(FieldColor), fieldColorArray[53]);
            FieldColor55 = Enum.GetName(typeof(FieldColor), fieldColorArray[54]);
            FieldColor56 = Enum.GetName(typeof(FieldColor), fieldColorArray[55]);
            FieldColor57 = Enum.GetName(typeof(FieldColor), fieldColorArray[56]);
            FieldColor58 = Enum.GetName(typeof(FieldColor), fieldColorArray[57]);
            FieldColor59 = Enum.GetName(typeof(FieldColor), fieldColorArray[58]);
            FieldColor60 = Enum.GetName(typeof(FieldColor), fieldColorArray[59]);
            FieldColor61 = Enum.GetName(typeof(FieldColor), fieldColorArray[60]);
            FieldColor62 = Enum.GetName(typeof(FieldColor), fieldColorArray[61]);
            FieldColor63 = Enum.GetName(typeof(FieldColor), fieldColorArray[62]);
            FieldColor64 = Enum.GetName(typeof(FieldColor), fieldColorArray[63]);
            FieldColor65 = Enum.GetName(typeof(FieldColor), fieldColorArray[64]);
            FieldColor66 = Enum.GetName(typeof(FieldColor), fieldColorArray[65]);
            FieldColor67 = Enum.GetName(typeof(FieldColor), fieldColorArray[66]);
            FieldColor68 = Enum.GetName(typeof(FieldColor), fieldColorArray[67]);
            FieldColor69 = Enum.GetName(typeof(FieldColor), fieldColorArray[68]);
            FieldColor70 = Enum.GetName(typeof(FieldColor), fieldColorArray[69]);
            FieldColor71 = Enum.GetName(typeof(FieldColor), fieldColorArray[70]);
            FieldColor72 = Enum.GetName(typeof(FieldColor), fieldColorArray[71]);
            FieldColor73 = Enum.GetName(typeof(FieldColor), fieldColorArray[72]);
            FieldColor74 = Enum.GetName(typeof(FieldColor), fieldColorArray[73]);
            FieldColor75 = Enum.GetName(typeof(FieldColor), fieldColorArray[74]);
            FieldColor76 = Enum.GetName(typeof(FieldColor), fieldColorArray[75]);
            FieldColor77 = Enum.GetName(typeof(FieldColor), fieldColorArray[76]);
            FieldColor78 = Enum.GetName(typeof(FieldColor), fieldColorArray[77]);
            FieldColor79 = Enum.GetName(typeof(FieldColor), fieldColorArray[78]);
            FieldColor80 = Enum.GetName(typeof(FieldColor), fieldColorArray[79]);
            FieldColor81 = Enum.GetName(typeof(FieldColor), fieldColorArray[80]);
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
            get => _field02;
            set
            {
                if (_field02 == value) return;
                _field02 = value;
                OnPropertyChanged(nameof(Field02));
            }
        }

        private string _field03 = string.Empty;
        public string Field03
        {
            get => _field03;
            set
            {
                if (_field03 == value) return;
                _field03 = value;
                OnPropertyChanged(nameof(Field03));
            }
        }

        private string _field04 = string.Empty;
        public string Field04
        {
            get => _field04;
            set
            {
                if (_field04 == value) return;
                _field04 = value;
                OnPropertyChanged(nameof(Field04));
            }
        }

        private string _field05 = string.Empty;
        public string Field05
        {
            get => _field05;
            set
            {
                if (_field05 == value) return;
                _field05 = value;
                OnPropertyChanged(nameof(Field05));
            }
        }

        private string _field06 = string.Empty;
        public string Field06
        {
            get => _field06;
            set
            {
                if (_field06 == value) return;
                _field06 = value;
                OnPropertyChanged(nameof(Field06));
            }
        }

        private string _field07 = string.Empty;
        public string Field07
        {
            get => _field07;
            set
            {
                if (_field07 == value) return;
                _field07 = value;
                OnPropertyChanged(nameof(Field07));
            }
        }

        private string _field08 = string.Empty;
        public string Field08
        {
            get => _field08;
            set
            {
                if (_field08 == value) return;
                _field08 = value;
                OnPropertyChanged(nameof(Field08));
            }
        }

        private string _field09 = string.Empty;
        public string Field09
        {
            get => _field09;
            set
            {
                if (_field09 == value) return;
                _field09 = value;
                OnPropertyChanged(nameof(Field09));
            }
        }

        private string _field10 = string.Empty;
        public string Field10
        {
            get => _field10;
            set
            {
                if (_field10 == value) return;
                _field10 = value;
                OnPropertyChanged(nameof(Field10));
            }
        }

        private string _field11 = string.Empty;
        public string Field11
        {
            get => _field11;
            set
            {
                if (_field11 == value) return;
                _field11 = value;
                OnPropertyChanged(nameof(Field11));
            }
        }

        private string _field12 = string.Empty;
        public string Field12
        {
            get => _field12;
            set
            {
                if (_field12 == value) return;
                _field12 = value;
                OnPropertyChanged(nameof(Field12));
            }
        }

        private string _field13 = string.Empty;
        public string Field13
        {
            get => _field13;
            set
            {
                if (_field13 == value) return;
                _field13 = value;
                OnPropertyChanged(nameof(Field13));
            }
        }

        private string _field14 = string.Empty;
        public string Field14
        {
            get => _field14;
            set
            {
                if (_field14 == value) return;
                _field14 = value;
                OnPropertyChanged(nameof(Field14));
            }
        }

        private string _field15 = string.Empty;
        public string Field15
        {
            get => _field15;
            set
            {
                if (_field15 == value) return;
                _field15 = value;
                OnPropertyChanged(nameof(Field15));
            }
        }

        private string _field16 = string.Empty;
        public string Field16
        {
            get => _field16;
            set
            {
                if (_field16 == value) return;
                _field16 = value;
                OnPropertyChanged(nameof(Field16));
            }
        }

        private string _field17 = string.Empty;
        public string Field17
        {
            get => _field17;
            set
            {
                if (_field17 == value) return;
                _field17 = value;
                OnPropertyChanged(nameof(Field17));
            }
        }

        private string _field18 = string.Empty;
        public string Field18
        {
            get => _field18;
            set
            {
                if (_field18 == value) return;
                _field18 = value;
                OnPropertyChanged(nameof(Field18));
            }
        }

        private string _field19 = string.Empty;
        public string Field19
        {
            get => _field19;
            set
            {
                if (_field19 == value) return;
                _field19 = value;
                OnPropertyChanged(nameof(Field19));
            }
        }

        private string _field20 = string.Empty;
        public string Field20
        {
            get => _field20;
            set
            {
                if (_field20 == value) return;
                _field20 = value;
                OnPropertyChanged(nameof(Field20));
            }
        }

        private string _field21 = string.Empty;
        public string Field21
        {
            get => _field21;
            set
            {
                if (_field21 == value) return;
                _field21 = value;
                OnPropertyChanged(nameof(Field21));
            }
        }

        private string _field22 = string.Empty;
        public string Field22
        {
            get => _field22;
            set
            {
                if (_field22 == value) return;
                _field22 = value;
                OnPropertyChanged(nameof(Field22));
            }
        }

        private string _field23 = string.Empty;
        public string Field23
        {
            get => _field23;
            set
            {
                if (_field23 == value) return;
                _field23 = value;
                OnPropertyChanged(nameof(Field23));
            }
        }

        private string _field24 = string.Empty;
        public string Field24
        {
            get => _field24;
            set
            {
                if (_field24 == value) return;
                _field24 = value;
                OnPropertyChanged(nameof(Field24));
            }
        }

        private string _field25 = string.Empty;
        public string Field25
        {
            get => _field25;
            set
            {
                if (_field25 == value) return;
                _field25 = value;
                OnPropertyChanged(nameof(Field25));
            }
        }

        private string _field26 = string.Empty;
        public string Field26
        {
            get => _field26;
            set
            {
                if (_field26 == value) return;
                _field26 = value;
                OnPropertyChanged(nameof(Field26));
            }
        }

        private string _field27 = string.Empty;
        public string Field27
        {
            get => _field27;
            set
            {
                if (_field27 == value) return;
                _field27 = value;
                OnPropertyChanged(nameof(Field27));
            }
        }

        private string _field28 = string.Empty;
        public string Field28
        {
            get => _field28;
            set
            {
                if (_field28 == value) return;
                _field28 = value;
                OnPropertyChanged(nameof(Field28));
            }
        }

        private string _field29 = string.Empty;
        public string Field29
        {
            get => _field29;
            set
            {
                if (_field29 == value) return;
                _field29 = value;
                OnPropertyChanged(nameof(Field29));
            }
        }

        private string _field30 = string.Empty;
        public string Field30
        {
            get => _field30;
            set
            {
                if (_field30 == value) return;
                _field30 = value;
                OnPropertyChanged(nameof(Field30));
            }
        }

        private string _field31 = string.Empty;
        public string Field31
        {
            get => _field31;
            set
            {
                if (_field31 == value) return;
                _field31 = value;
                OnPropertyChanged(nameof(Field31));
            }
        }

        private string _field32 = string.Empty;
        public string Field32
        {
            get => _field32;
            set
            {
                if (_field32 == value) return;
                _field32 = value;
                OnPropertyChanged(nameof(Field32));
            }
        }

        private string _field33 = string.Empty;
        public string Field33
        {
            get => _field33;
            set
            {
                if (_field33 == value) return;
                _field33 = value;
                OnPropertyChanged(nameof(Field33));
            }
        }

        private string _field34 = string.Empty;
        public string Field34
        {
            get => _field34;
            set
            {
                if (_field34 == value) return;
                _field34 = value;
                OnPropertyChanged(nameof(Field34));
            }
        }

        private string _field35 = string.Empty;
        public string Field35
        {
            get => _field35;
            set
            {
                if (_field35 == value) return;
                _field35 = value;
                OnPropertyChanged(nameof(Field35));
            }
        }


        private string _field36 = string.Empty;
        public string Field36
        {
            get => _field36;
            set
            {
                if (_field36 == value) return;
                _field36 = value;
                OnPropertyChanged(nameof(Field36));
            }
        }

        private string _field37 = string.Empty;
        public string Field37
        {
            get => _field37;
            set
            {
                if (_field37 == value) return;
                _field37 = value;
                OnPropertyChanged(nameof(Field37));
            }
        }

        private string _field38 = string.Empty;
        public string Field38
        {
            get => _field38;
            set
            {
                if (_field38 == value) return;
                _field38 = value;
                OnPropertyChanged(nameof(Field38));
            }
        }

        private string _field39 = string.Empty;
        public string Field39
        {
            get => _field39;
            set
            {
                if (_field39 == value) return;
                _field39 = value;
                OnPropertyChanged(nameof(Field39));
            }
        }

        private string _field40 = string.Empty;
        public string Field40
        {
            get => _field40;
            set
            {
                if (_field40 == value) return;
                _field40 = value;
                OnPropertyChanged(nameof(Field40));
            }
        }

        private string _field41 = string.Empty;
        public string Field41
        {
            get => _field41;
            set
            {
                if (_field41 == value) return;
                _field41 = value;
                OnPropertyChanged(nameof(Field41));
            }
        }

        private string _field42 = string.Empty;
        public string Field42
        {
            get => _field42;
            set
            {
                if (_field42 == value) return;
                _field42 = value;
                OnPropertyChanged(nameof(Field42));
            }
        }

        private string _field43 = string.Empty;
        public string Field43
        {
            get => _field43;
            set
            {
                if (_field43 == value) return;
                _field43 = value;
                OnPropertyChanged(nameof(Field43));
            }
        }

        private string _field44 = string.Empty;
        public string Field44
        {
            get => _field44;
            set
            {
                if (_field44 == value) return;
                _field44 = value;
                OnPropertyChanged(nameof(Field44));
            }
        }

        private string _field45 = string.Empty;
        public string Field45
        {
            get => _field45;
            set
            {
                if (_field45 == value) return;
                _field45 = value;
                OnPropertyChanged(nameof(Field45));
            }
        }

        private string _field46 = string.Empty;
        public string Field46
        {
            get => _field46;
            set
            {
                if (_field46 == value) return;
                _field46 = value;
                OnPropertyChanged(nameof(Field46));
            }
        }

        private string _field47 = string.Empty;
        public string Field47
        {
            get => _field47;
            set
            {
                if (_field47 == value) return;
                _field47 = value;
                OnPropertyChanged(nameof(Field47));
            }
        }

        private string _field48 = string.Empty;
        public string Field48
        {
            get => _field48;
            set
            {
                if (_field48 == value) return;
                _field48 = value;
                OnPropertyChanged(nameof(Field48));
            }
        }

        private string _field49 = string.Empty;
        public string Field49
        {
            get => _field49;
            set
            {
                if (_field49 == value) return;
                _field49 = value;
                OnPropertyChanged(nameof(Field49));
            }
        }

        private string _field50 = string.Empty;
        public string Field50
        {
            get => _field50;
            set
            {
                if (_field50 == value) return;
                _field50 = value;
                OnPropertyChanged(nameof(Field50));
            }
        }

        private string _field51 = string.Empty;
        public string Field51
        {
            get => _field51;
            set
            {
                if (_field51 == value) return;
                _field51 = value;
                OnPropertyChanged(nameof(Field51));
            }
        }

        private string _field52 = string.Empty;
        public string Field52
        {
            get => _field52;
            set
            {
                if (_field52 == value) return;
                _field52 = value;
                OnPropertyChanged(nameof(Field52));
            }
        }

        private string _field53 = string.Empty;
        public string Field53
        {
            get => _field53;
            set
            {
                if (_field53 == value) return;
                _field53 = value;
                OnPropertyChanged(nameof(Field53));
            }
        }

        private string _field54 = string.Empty;
        public string Field54
        {
            get => _field54;
            set
            {
                if (_field54 == value) return;
                _field54 = value;
                OnPropertyChanged(nameof(Field54));
            }
        }

        private string _field55 = string.Empty;
        public string Field55
        {
            get => _field55;
            set
            {
                if (_field55 == value) return;
                _field55 = value;
                OnPropertyChanged(nameof(Field55));
            }
        }

        private string _field56 = string.Empty;
        public string Field56
        {
            get => _field56;
            set
            {
                if (_field56 == value) return;
                _field56 = value;
                OnPropertyChanged(nameof(Field56));
            }
        }

        private string _field57 = string.Empty;
        public string Field57
        {
            get => _field57;
            set
            {
                if (_field57 == value) return;
                _field57 = value;
                OnPropertyChanged(nameof(Field57));
            }
        }

        private string _field58 = string.Empty;
        public string Field58
        {
            get => _field58;
            set
            {
                if (_field58 == value) return;
                _field58 = value;
                OnPropertyChanged(nameof(Field58));
            }
        }

        private string _field59 = string.Empty;
        public string Field59
        {
            get => _field59;
            set
            {
                if (_field59 == value) return;
                _field59 = value;
                OnPropertyChanged(nameof(Field59));
            }
        }

        private string _field60 = string.Empty;
        public string Field60
        {
            get => _field60;
            set
            {
                if (_field60 == value) return;
                _field60 = value;
                OnPropertyChanged(nameof(Field60));
            }
        }

        private string _field61 = string.Empty;
        public string Field61
        {
            get => _field61;
            set
            {
                if (_field61 == value) return;
                _field61 = value;
                OnPropertyChanged(nameof(Field61));
            }
        }

        private string _field62 = string.Empty;
        public string Field62
        {
            get => _field62;
            set
            {
                if (_field62 == value) return;
                _field62 = value;
                OnPropertyChanged(nameof(Field62));
            }
        }

        private string _field63 = string.Empty;
        public string Field63
        {
            get => _field63;
            set
            {
                if (_field63 == value) return;
                _field63 = value;
                OnPropertyChanged(nameof(Field63));
            }
        }

        private string _field64 = string.Empty;
        public string Field64
        {
            get => _field64;
            set
            {
                if (_field64 == value) return;
                _field64 = value;
                OnPropertyChanged(nameof(Field64));
            }
        }

        private string _field65 = string.Empty;
        public string Field65
        {
            get => _field65;
            set
            {
                if (_field65 == value) return;
                _field65 = value;
                OnPropertyChanged(nameof(Field65));
            }
        }

        private string _field66 = string.Empty;
        public string Field66
        {
            get => _field66;
            set
            {
                if (_field66 == value) return;
                _field66 = value;
                OnPropertyChanged(nameof(Field66));
            }
        }

        private string _field67 = string.Empty;
        public string Field67
        {
            get => _field67;
            set
            {
                if (_field67 == value) return;
                _field67 = value;
                OnPropertyChanged(nameof(Field67));
            }
        }

        private string _field68 = string.Empty;
        public string Field68
        {
            get => _field68;
            set
            {
                if (_field68 == value) return;
                _field68 = value;
                OnPropertyChanged(nameof(Field68));
            }
        }

        private string _field69 = string.Empty;
        public string Field69
        {
            get => _field69;
            set
            {
                if (_field69 == value) return;
                _field69 = value;
                OnPropertyChanged(nameof(Field69));
            }
        }

        private string _field70 = string.Empty;
        public string Field70
        {
            get => _field70;
            set
            {
                if (_field70 == value) return;
                _field70 = value;
                OnPropertyChanged(nameof(Field70));
            }
        }

        private string _field71 = string.Empty;
        public string Field71
        {
            get => _field71;
            set
            {
                if (_field71 == value) return;
                _field71 = value;
                OnPropertyChanged(nameof(Field71));
            }
        }

        private string _field72 = string.Empty;
        public string Field72
        {
            get => _field72;
            set
            {
                if (_field72 == value) return;
                _field72 = value;
                OnPropertyChanged(nameof(Field72));
            }
        }

        private string _field73 = string.Empty;
        public string Field73
        {
            get => _field73;
            set
            {
                if (_field73 == value) return;
                _field73 = value;
                OnPropertyChanged(nameof(Field73));
            }
        }

        private string _field74 = string.Empty;
        public string Field74
        {
            get => _field74;
            set
            {
                if (_field74 == value) return;
                _field74 = value;
                OnPropertyChanged(nameof(Field74));
            }
        }

        private string _field75 = string.Empty;
        public string Field75
        {
            get => _field75;
            set
            {
                if (_field75 == value) return;
                _field75 = value;
                OnPropertyChanged(nameof(Field75));
            }
        }

        private string _field76 = string.Empty;
        public string Field76
        {
            get => _field76;
            set
            {
                if (_field76 == value) return;
                _field76 = value;
                OnPropertyChanged(nameof(Field76));
            }
        }

        private string _field77 = string.Empty;
        public string Field77
        {
            get => _field77;
            set
            {
                if (_field77 == value) return;
                _field77 = value;
                OnPropertyChanged(nameof(Field77));
            }
        }

        private string _field78 = string.Empty;
        public string Field78
        {
            get => _field78;
            set
            {
                if (_field78 == value) return;
                _field78 = value;
                OnPropertyChanged(nameof(Field78));
            }
        }

        private string _field79 = string.Empty;
        public string Field79
        {
            get => _field79;
            set
            {
                if (_field79 == value) return;
                _field79 = value;
                OnPropertyChanged(nameof(Field79));
            }
        }

        private string _field80 = string.Empty;
        public string Field80
        {
            get => _field80;
            set
            {
                if (_field80 == value) return;
                _field80 = value;
                OnPropertyChanged(nameof(Field80));
            }
        }

        private string _field81 = string.Empty;
        public string Field81
        {
            get => _field81;
            set
            {
                if (_field81 == value) return;
                _field81 = value;
                OnPropertyChanged(nameof(Field81));
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
            get => _isEnabled02;
            set
            {
                if (_isEnabled02 == value) return;
                _isEnabled02 = value;
                OnPropertyChanged(nameof(IsEnabled02));
            }
        }

        private string _isEnabled03 = string.Empty;
        public string IsEnabled03
        {
            get => _isEnabled03;
            set
            {
                if (_isEnabled03 == value) return;
                _isEnabled03 = value;
                OnPropertyChanged(nameof(IsEnabled03));
            }
        }

        private string _isEnabled04 = string.Empty;
        public string IsEnabled04
        {
            get => _isEnabled04;
            set
            {
                if (_isEnabled04 == value) return;
                _isEnabled04 = value;
                OnPropertyChanged(nameof(IsEnabled04));
            }
        }

        private string _isEnabled05 = string.Empty;
        public string IsEnabled05
        {
            get => _isEnabled05;
            set
            {
                if (_isEnabled05 == value) return;
                _isEnabled05 = value;
                OnPropertyChanged(nameof(IsEnabled05));
            }
        }

        private string _isEnabled06 = string.Empty;
        public string IsEnabled06
        {
            get => _isEnabled06;
            set
            {
                if (_isEnabled06 == value) return;
                _isEnabled06 = value;
                OnPropertyChanged(nameof(IsEnabled06));
            }
        }

        private string _isEnabled07 = string.Empty;
        public string IsEnabled07
        {
            get => _isEnabled07;
            set
            {
                if (_isEnabled07 == value) return;
                _isEnabled07 = value;
                OnPropertyChanged(nameof(IsEnabled07));
            }
        }

        private string _isEnabled08 = string.Empty;
        public string IsEnabled08
        {
            get => _isEnabled08;
            set
            {
                if (_isEnabled08 == value) return;
                _isEnabled08 = value;
                OnPropertyChanged(nameof(IsEnabled08));
            }
        }

        private string _isEnabled09 = string.Empty;
        public string IsEnabled09
        {
            get => _isEnabled09;
            set
            {
                if (_isEnabled09 == value) return;
                _isEnabled09 = value;
                OnPropertyChanged(nameof(IsEnabled09));
            }
        }

        private string _isEnabled10 = string.Empty;
        public string IsEnabled10
        {
            get => _isEnabled10;
            set
            {
                if (_isEnabled10 == value) return;
                _isEnabled10 = value;
                OnPropertyChanged(nameof(IsEnabled10));
            }
        }

        private string _isEnabled11 = string.Empty;
        public string IsEnabled11
        {
            get => _isEnabled11;
            set
            {
                if (_isEnabled11 == value) return;
                _isEnabled11 = value;
                OnPropertyChanged(nameof(IsEnabled11));
            }
        }

        private string _isEnabled12 = string.Empty;
        public string IsEnabled12
        {
            get => _isEnabled12;
            set
            {
                if (_isEnabled12 == value) return;
                _isEnabled12 = value;
                OnPropertyChanged(nameof(IsEnabled12));
            }
        }

        private string _isEnabled13 = string.Empty;
        public string IsEnabled13
        {
            get => _isEnabled13;
            set
            {
                if (_isEnabled13 == value) return;
                _isEnabled13 = value;
                OnPropertyChanged(nameof(IsEnabled13));
            }
        }

        private string _isEnabled14 = string.Empty;
        public string IsEnabled14
        {
            get => _isEnabled14;
            set
            {
                if (_isEnabled14 == value) return;
                _isEnabled14 = value;
                OnPropertyChanged(nameof(IsEnabled14));
            }
        }

        private string _isEnabled15 = string.Empty;
        public string IsEnabled15
        {
            get => _isEnabled15;
            set
            {
                if (_isEnabled15 == value) return;
                _isEnabled15 = value;
                OnPropertyChanged(nameof(IsEnabled15));
            }
        }

        private string _isEnabled16 = string.Empty;
        public string IsEnabled16
        {
            get => _isEnabled16;
            set
            {
                if (_isEnabled16 == value) return;
                _isEnabled16 = value;
                OnPropertyChanged(nameof(IsEnabled16));
            }
        }

        private string _isEnabled17 = string.Empty;
        public string IsEnabled17
        {
            get => _isEnabled17;
            set
            {
                if (_isEnabled17 == value) return;
                _isEnabled17 = value;
                OnPropertyChanged(nameof(IsEnabled17));
            }
        }

        private string _isEnabled18 = string.Empty;
        public string IsEnabled18
        {
            get => _isEnabled18;
            set
            {
                if (_isEnabled18 == value) return;
                _isEnabled18 = value;
                OnPropertyChanged(nameof(IsEnabled18));
            }
        }

        private string _isEnabled19 = string.Empty;
        public string IsEnabled19
        {
            get => _isEnabled19;
            set
            {
                if (_isEnabled19 == value) return;
                _isEnabled19 = value;
                OnPropertyChanged(nameof(IsEnabled19));
            }
        }

        private string _isEnabled20 = string.Empty;
        public string IsEnabled20
        {
            get => _isEnabled20;
            set
            {
                if (_isEnabled20 == value) return;
                _isEnabled20 = value;
                OnPropertyChanged(nameof(IsEnabled20));
            }
        }

        private string _isEnabled21 = string.Empty;
        public string IsEnabled21
        {
            get => _isEnabled21;
            set
            {
                if (_isEnabled21 == value) return;
                _isEnabled21 = value;
                OnPropertyChanged(nameof(IsEnabled21));
            }
        }

        private string _isEnabled22 = string.Empty;
        public string IsEnabled22
        {
            get => _isEnabled22;
            set
            {
                if (_isEnabled22 == value) return;
                _isEnabled22 = value;
                OnPropertyChanged(nameof(IsEnabled22));
            }
        }

        private string _isEnabled23 = string.Empty;
        public string IsEnabled23
        {
            get => _isEnabled23;
            set
            {
                if (_isEnabled23 == value) return;
                _isEnabled23 = value;
                OnPropertyChanged(nameof(IsEnabled23));
            }
        }

        private string _isEnabled24 = string.Empty;
        public string IsEnabled24
        {
            get => _isEnabled24;
            set
            {
                if (_isEnabled24 == value) return;
                _isEnabled24 = value;
                OnPropertyChanged(nameof(IsEnabled24));
            }
        }

        private string _isEnabled25 = string.Empty;
        public string IsEnabled25
        {
            get => _isEnabled25;
            set
            {
                if (_isEnabled25 == value) return;
                _isEnabled25 = value;
                OnPropertyChanged(nameof(IsEnabled25));
            }
        }

        private string _isEnabled26 = string.Empty;
        public string IsEnabled26
        {
            get => _isEnabled26;
            set
            {
                if (_isEnabled26 == value) return;
                _isEnabled26 = value;
                OnPropertyChanged(nameof(IsEnabled26));
            }
        }

        private string _isEnabled27 = string.Empty;
        public string IsEnabled27
        {
            get => _isEnabled27;
            set
            {
                if (_isEnabled27 == value) return;
                _isEnabled27 = value;
                OnPropertyChanged(nameof(IsEnabled27));
            }
        }

        private string _isEnabled28 = string.Empty;
        public string IsEnabled28
        {
            get => _isEnabled28;
            set
            {
                if (_isEnabled28 == value) return;
                _isEnabled28 = value;
                OnPropertyChanged(nameof(IsEnabled28));
            }
        }

        private string _isEnabled29 = string.Empty;
        public string IsEnabled29
        {
            get => _isEnabled29;
            set
            {
                if (_isEnabled29 == value) return;
                _isEnabled29 = value;
                OnPropertyChanged(nameof(IsEnabled29));
            }
        }

        private string _isEnabled30 = string.Empty;
        public string IsEnabled30
        {
            get => _isEnabled30;
            set
            {
                if (_isEnabled30 == value) return;
                _isEnabled30 = value;
                OnPropertyChanged(nameof(IsEnabled30));
            }
        }

        private string _isEnabled31 = string.Empty;
        public string IsEnabled31
        {
            get => _isEnabled31;
            set
            {
                if (_isEnabled31 == value) return;
                _isEnabled31 = value;
                OnPropertyChanged(nameof(IsEnabled31));
            }
        }

        private string _isEnabled32 = string.Empty;
        public string IsEnabled32
        {
            get => _isEnabled32;
            set
            {
                if (_isEnabled32 == value) return;
                _isEnabled32 = value;
                OnPropertyChanged(nameof(IsEnabled32));
            }
        }

        private string _isEnabled33 = string.Empty;
        public string IsEnabled33
        {
            get => _isEnabled33;
            set
            {
                if (_isEnabled33 == value) return;
                _isEnabled33 = value;
                OnPropertyChanged(nameof(IsEnabled33));
            }
        }

        private string _isEnabled34 = string.Empty;
        public string IsEnabled34
        {
            get => _isEnabled34;
            set
            {
                if (_isEnabled34 == value) return;
                _isEnabled34 = value;
                OnPropertyChanged(nameof(IsEnabled34));
            }
        }

        private string _isEnabled35 = string.Empty;
        public string IsEnabled35
        {
            get => _isEnabled35;
            set
            {
                if (_isEnabled35 == value) return;
                _isEnabled35 = value;
                OnPropertyChanged(nameof(IsEnabled35));
            }
        }


        private string _isEnabled36 = string.Empty;
        public string IsEnabled36
        {
            get => _isEnabled36;
            set
            {
                if (_isEnabled36 == value) return;
                _isEnabled36 = value;
                OnPropertyChanged(nameof(IsEnabled36));
            }
        }

        private string _isEnabled37 = string.Empty;
        public string IsEnabled37
        {
            get => _isEnabled37;
            set
            {
                if (_isEnabled37 == value) return;
                _isEnabled37 = value;
                OnPropertyChanged(nameof(IsEnabled37));
            }
        }

        private string _isEnabled38 = string.Empty;
        public string IsEnabled38
        {
            get => _isEnabled38;
            set
            {
                if (_isEnabled38 == value) return;
                _isEnabled38 = value;
                OnPropertyChanged(nameof(IsEnabled38));
            }
        }

        private string _isEnabled39 = string.Empty;
        public string IsEnabled39
        {
            get => _isEnabled39;
            set
            {
                if (_isEnabled39 == value) return;
                _isEnabled39 = value;
                OnPropertyChanged(nameof(IsEnabled39));
            }
        }

        private string _isEnabled40 = string.Empty;
        public string IsEnabled40
        {
            get => _isEnabled40;
            set
            {
                if (_isEnabled40 == value) return;
                _isEnabled40 = value;
                OnPropertyChanged(nameof(IsEnabled40));
            }
        }

        private string _isEnabled41 = string.Empty;
        public string IsEnabled41
        {
            get => _isEnabled41;
            set
            {
                if (_isEnabled41 == value) return;
                _isEnabled41 = value;
                OnPropertyChanged(nameof(IsEnabled41));
            }
        }

        private string _isEnabled42 = string.Empty;
        public string IsEnabled42
        {
            get => _isEnabled42;
            set
            {
                if (_isEnabled42 == value) return;
                _isEnabled42 = value;
                OnPropertyChanged(nameof(IsEnabled42));
            }
        }

        private string _isEnabled43 = string.Empty;
        public string IsEnabled43
        {
            get => _isEnabled43;
            set
            {
                if (_isEnabled43 == value) return;
                _isEnabled43 = value;
                OnPropertyChanged(nameof(IsEnabled43));
            }
        }

        private string _isEnabled44 = string.Empty;
        public string IsEnabled44
        {
            get => _isEnabled44;
            set
            {
                if (_isEnabled44 == value) return;
                _isEnabled44 = value;
                OnPropertyChanged(nameof(IsEnabled44));
            }
        }

        private string _isEnabled45 = string.Empty;
        public string IsEnabled45
        {
            get => _isEnabled45;
            set
            {
                if (_isEnabled45 == value) return;
                _isEnabled45 = value;
                OnPropertyChanged(nameof(IsEnabled45));
            }
        }

        private string _isEnabled46 = string.Empty;
        public string IsEnabled46
        {
            get => _isEnabled46;
            set
            {
                if (_isEnabled46 == value) return;
                _isEnabled46 = value;
                OnPropertyChanged(nameof(IsEnabled46));
            }
        }

        private string _isEnabled47 = string.Empty;
        public string IsEnabled47
        {
            get => _isEnabled47;
            set
            {
                if (_isEnabled47 == value) return;
                _isEnabled47 = value;
                OnPropertyChanged(nameof(IsEnabled47));
            }
        }

        private string _isEnabled48 = string.Empty;
        public string IsEnabled48
        {
            get => _isEnabled48;
            set
            {
                if (_isEnabled48 == value) return;
                _isEnabled48 = value;
                OnPropertyChanged(nameof(IsEnabled48));
            }
        }

        private string _isEnabled49 = string.Empty;
        public string IsEnabled49
        {
            get => _isEnabled49;
            set
            {
                if (_isEnabled49 == value) return;
                _isEnabled49 = value;
                OnPropertyChanged(nameof(IsEnabled49));
            }
        }

        private string _isEnabled50 = string.Empty;
        public string IsEnabled50
        {
            get => _isEnabled50;
            set
            {
                if (_isEnabled50 == value) return;
                _isEnabled50 = value;
                OnPropertyChanged(nameof(IsEnabled50));
            }
        }

        private string _isEnabled51 = string.Empty;
        public string IsEnabled51
        {
            get => _isEnabled51;
            set
            {
                if (_isEnabled51 == value) return;
                _isEnabled51 = value;
                OnPropertyChanged(nameof(IsEnabled51));
            }
        }

        private string _isEnabled52 = string.Empty;
        public string IsEnabled52
        {
            get => _isEnabled52;
            set
            {
                if (_isEnabled52 == value) return;
                _isEnabled52 = value;
                OnPropertyChanged(nameof(IsEnabled52));
            }
        }

        private string _isEnabled53 = string.Empty;
        public string IsEnabled53
        {
            get => _isEnabled53;
            set
            {
                if (_isEnabled53 == value) return;
                _isEnabled53 = value;
                OnPropertyChanged(nameof(IsEnabled53));
            }
        }

        private string _isEnabled54 = string.Empty;
        public string IsEnabled54
        {
            get => _isEnabled54;
            set
            {
                if (_isEnabled54 == value) return;
                _isEnabled54 = value;
                OnPropertyChanged(nameof(IsEnabled54));
            }
        }

        private string _isEnabled55 = string.Empty;
        public string IsEnabled55
        {
            get => _isEnabled55;
            set
            {
                if (_isEnabled55 == value) return;
                _isEnabled55 = value;
                OnPropertyChanged(nameof(IsEnabled55));
            }
        }

        private string _isEnabled56 = string.Empty;
        public string IsEnabled56
        {
            get => _isEnabled56;
            set
            {
                if (_isEnabled56 == value) return;
                _isEnabled56 = value;
                OnPropertyChanged(nameof(IsEnabled56));
            }
        }

        private string _isEnabled57 = string.Empty;
        public string IsEnabled57
        {
            get => _isEnabled57;
            set
            {
                if (_isEnabled57 == value) return;
                _isEnabled57 = value;
                OnPropertyChanged(nameof(IsEnabled57));
            }
        }

        private string _isEnabled58 = string.Empty;
        public string IsEnabled58
        {
            get => _isEnabled58;
            set
            {
                if (_isEnabled58 == value) return;
                _isEnabled58 = value;
                OnPropertyChanged(nameof(IsEnabled58));
            }
        }

        private string _isEnabled59 = string.Empty;
        public string IsEnabled59
        {
            get => _isEnabled59;
            set
            {
                if (_isEnabled59 == value) return;
                _isEnabled59 = value;
                OnPropertyChanged(nameof(IsEnabled59));
            }
        }

        private string _isEnabled60 = string.Empty;
        public string IsEnabled60
        {
            get => _isEnabled60;
            set
            {
                if (_isEnabled60 == value) return;
                _isEnabled60 = value;
                OnPropertyChanged(nameof(IsEnabled60));
            }
        }

        private string _isEnabled61 = string.Empty;
        public string IsEnabled61
        {
            get => _isEnabled61;
            set
            {
                if (_isEnabled61 == value) return;
                _isEnabled61 = value;
                OnPropertyChanged(nameof(IsEnabled61));
            }
        }

        private string _isEnabled62 = string.Empty;
        public string IsEnabled62
        {
            get => _isEnabled62;
            set
            {
                if (_isEnabled62 == value) return;
                _isEnabled62 = value;
                OnPropertyChanged(nameof(IsEnabled62));
            }
        }

        private string _isEnabled63 = string.Empty;
        public string IsEnabled63
        {
            get => _isEnabled63;
            set
            {
                if (_isEnabled63 == value) return;
                _isEnabled63 = value;
                OnPropertyChanged(nameof(IsEnabled63));
            }
        }

        private string _isEnabled64 = string.Empty;
        public string IsEnabled64
        {
            get => _isEnabled64;
            set
            {
                if (_isEnabled64 == value) return;
                _isEnabled64 = value;
                OnPropertyChanged(nameof(IsEnabled64));
            }
        }

        private string _isEnabled65 = string.Empty;
        public string IsEnabled65
        {
            get => _isEnabled65;
            set
            {
                if (_isEnabled65 == value) return;
                _isEnabled65 = value;
                OnPropertyChanged(nameof(IsEnabled65));
            }
        }

        private string _isEnabled66 = string.Empty;
        public string IsEnabled66
        {
            get => _isEnabled66;
            set
            {
                if (_isEnabled66 == value) return;
                _isEnabled66 = value;
                OnPropertyChanged(nameof(IsEnabled66));
            }
        }

        private string _isEnabled67 = string.Empty;
        public string IsEnabled67
        {
            get => _isEnabled67;
            set
            {
                if (_isEnabled67 == value) return;
                _isEnabled67 = value;
                OnPropertyChanged(nameof(IsEnabled67));
            }
        }

        private string _isEnabled68 = string.Empty;
        public string IsEnabled68
        {
            get => _isEnabled68;
            set
            {
                if (_isEnabled68 == value) return;
                _isEnabled68 = value;
                OnPropertyChanged(nameof(IsEnabled68));
            }
        }

        private string _isEnabled69 = string.Empty;
        public string IsEnabled69
        {
            get => _isEnabled69;
            set
            {
                if (_isEnabled69 == value) return;
                _isEnabled69 = value;
                OnPropertyChanged(nameof(IsEnabled69));
            }
        }

        private string _isEnabled70 = string.Empty;
        public string IsEnabled70
        {
            get => _isEnabled70;
            set
            {
                if (_isEnabled70 == value) return;
                _isEnabled70 = value;
                OnPropertyChanged(nameof(IsEnabled70));
            }
        }

        private string _isEnabled71 = string.Empty;
        public string IsEnabled71
        {
            get => _isEnabled71;
            set
            {
                if (_isEnabled71 == value) return;
                _isEnabled71 = value;
                OnPropertyChanged(nameof(IsEnabled71));
            }
        }

        private string _isEnabled72 = string.Empty;
        public string IsEnabled72
        {
            get => _isEnabled72;
            set
            {
                if (_isEnabled72 == value) return;
                _isEnabled72 = value;
                OnPropertyChanged(nameof(IsEnabled72));
            }
        }

        private string _isEnabled73 = string.Empty;
        public string IsEnabled73
        {
            get => _isEnabled73;
            set
            {
                if (_isEnabled73 == value) return;
                _isEnabled73 = value;
                OnPropertyChanged(nameof(IsEnabled73));
            }
        }

        private string _isEnabled74 = string.Empty;
        public string IsEnabled74
        {
            get => _isEnabled74;
            set
            {
                if (_isEnabled74 == value) return;
                _isEnabled74 = value;
                OnPropertyChanged(nameof(IsEnabled74));
            }
        }

        private string _isEnabled75 = string.Empty;
        public string IsEnabled75
        {
            get => _isEnabled75;
            set
            {
                if (_isEnabled75 == value) return;
                _isEnabled75 = value;
                OnPropertyChanged(nameof(IsEnabled75));
            }
        }

        private string _isEnabled76 = string.Empty;
        public string IsEnabled76
        {
            get => _isEnabled76;
            set
            {
                if (_isEnabled76 == value) return;
                _isEnabled76 = value;
                OnPropertyChanged(nameof(IsEnabled76));
            }
        }

        private string _isEnabled77 = string.Empty;
        public string IsEnabled77
        {
            get => _isEnabled77;
            set
            {
                if (_isEnabled77 == value) return;
                _isEnabled77 = value;
                OnPropertyChanged(nameof(IsEnabled77));
            }
        }

        private string _isEnabled78 = string.Empty;
        public string IsEnabled78
        {
            get => _isEnabled78;
            set
            {
                if (_isEnabled78 == value) return;
                _isEnabled78 = value;
                OnPropertyChanged(nameof(IsEnabled78));
            }
        }

        private string _isEnabled79 = string.Empty;
        public string IsEnabled79
        {
            get => _isEnabled79;
            set
            {
                if (_isEnabled79 == value) return;
                _isEnabled79 = value;
                OnPropertyChanged(nameof(IsEnabled79));
            }
        }

        private string _isEnabled80 = string.Empty;
        public string IsEnabled80
        {
            get => _isEnabled80;
            set
            {
                if (_isEnabled80 == value) return;
                _isEnabled80 = value;
                OnPropertyChanged(nameof(IsEnabled80));
            }
        }

        private string _isEnabled81 = string.Empty;
        public string IsEnabled81
        {
            get => _isEnabled81;
            set
            {
                if (_isEnabled81 == value) return;
                _isEnabled81 = value;
                OnPropertyChanged(nameof(IsEnabled81));
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
            get => _fieldColor02;
            set
            {
                if (_fieldColor02 == value) return;
                _fieldColor02 = value;
                OnPropertyChanged(nameof(FieldColor02));
            }
        }

        private string _fieldColor03 = "black";
        public string FieldColor03
        {
            get => _fieldColor03;
            set
            {
                if (_fieldColor03 == value) return;
                _fieldColor03 = value;
                OnPropertyChanged(nameof(FieldColor03));
            }
        }

        private string _fieldColor04 = "black";
        public string FieldColor04
        {
            get => _fieldColor04;
            set
            {
                if (_fieldColor04 == value) return;
                _fieldColor04 = value;
                OnPropertyChanged(nameof(FieldColor04));
            }
        }

        private string _fieldColor05 = "black";
        public string FieldColor05
        {
            get => _fieldColor05;
            set
            {
                if (_fieldColor05 == value) return;
                _fieldColor05 = value;
                OnPropertyChanged(nameof(FieldColor05));
            }
        }

        private string _fieldColor06 = "black";
        public string FieldColor06
        {
            get => _fieldColor06;
            set
            {
                if (_fieldColor06 == value) return;
                _fieldColor06 = value;
                OnPropertyChanged(nameof(FieldColor06));
            }
        }

        private string _fieldColor07 = "black";
        public string FieldColor07
        {
            get => _fieldColor07;
            set
            {
                if (_fieldColor07 == value) return;
                _fieldColor07 = value;
                OnPropertyChanged(nameof(FieldColor07));
            }
        }

        private string _fieldColor08 = "black";
        public string FieldColor08
        {
            get => _fieldColor08;
            set
            {
                if (_fieldColor08 == value) return;
                _fieldColor08 = value;
                OnPropertyChanged(nameof(FieldColor08));
            }
        }

        private string _fieldColor09 = "black";
        public string FieldColor09
        {
            get => _fieldColor09;
            set
            {
                if (_fieldColor09 == value) return;
                _fieldColor09 = value;
                OnPropertyChanged(nameof(FieldColor09));
            }
        }

        private string _fieldColor10 = "black";
        public string FieldColor10
        {
            get => _fieldColor10;
            set
            {
                if (_fieldColor10 == value) return;
                _fieldColor10 = value;
                OnPropertyChanged(nameof(FieldColor10));
            }
        }

        private string _fieldColor11 = "black";
        public string FieldColor11
        {
            get => _fieldColor11;
            set
            {
                if (_fieldColor11 == value) return;
                _fieldColor11 = value;
                OnPropertyChanged(nameof(FieldColor11));
            }
        }

        private string _fieldColor12 = "black";
        public string FieldColor12
        {
            get => _fieldColor12;
            set
            {
                if (_fieldColor12 == value) return;
                _fieldColor12 = value;
                OnPropertyChanged(nameof(FieldColor12));
            }
        }

        private string _fieldColor13 = "black";
        public string FieldColor13
        {
            get => _fieldColor13;
            set
            {
                if (_fieldColor13 == value) return;
                _fieldColor13 = value;
                OnPropertyChanged(nameof(FieldColor13));
            }
        }

        private string _fieldColor14 = "black";
        public string FieldColor14
        {
            get => _fieldColor14;
            set
            {
                if (_fieldColor14 == value) return;
                _fieldColor14 = value;
                OnPropertyChanged(nameof(FieldColor14));
            }
        }

        private string _fieldColor15 = "black";
        public string FieldColor15
        {
            get => _fieldColor15;
            set
            {
                if (_fieldColor15 == value) return;
                _fieldColor15 = value;
                OnPropertyChanged(nameof(FieldColor15));
            }
        }

        private string _fieldColor16 = "black";
        public string FieldColor16
        {
            get => _fieldColor16;
            set
            {
                if (_fieldColor16 == value) return;
                _fieldColor16 = value;
                OnPropertyChanged(nameof(FieldColor16));
            }
        }

        private string _fieldColor17 = "black";
        public string FieldColor17
        {
            get => _fieldColor17;
            set
            {
                if (_fieldColor17 == value) return;
                _fieldColor17 = value;
                OnPropertyChanged(nameof(FieldColor17));
            }
        }

        private string _fieldColor18 = "black";
        public string FieldColor18
        {
            get => _fieldColor18;
            set
            {
                if (_fieldColor18 == value) return;
                _fieldColor18 = value;
                OnPropertyChanged(nameof(FieldColor18));
            }
        }

        private string _fieldColor19 = "black";
        public string FieldColor19
        {
            get => _fieldColor19;
            set
            {
                if (_fieldColor19 == value) return;
                _fieldColor19 = value;
                OnPropertyChanged(nameof(FieldColor19));
            }
        }

        private string _fieldColor20 = "black";
        public string FieldColor20
        {
            get => _fieldColor20;
            set
            {
                if (_fieldColor20 == value) return;
                _fieldColor20 = value;
                OnPropertyChanged(nameof(FieldColor20));
            }
        }

        private string _fieldColor21 = "black";
        public string FieldColor21
        {
            get => _fieldColor21;
            set
            {
                if (_fieldColor21 == value) return;
                _fieldColor21 = value;
                OnPropertyChanged(nameof(FieldColor21));
            }
        }

        private string _fieldColor22 = "black";
        public string FieldColor22
        {
            get => _fieldColor22;
            set
            {
                if (_fieldColor22 == value) return;
                _fieldColor22 = value;
                OnPropertyChanged(nameof(FieldColor22));
            }
        }

        private string _fieldColor23 = "black";
        public string FieldColor23
        {
            get => _fieldColor23;
            set
            {
                if (_fieldColor23 == value) return;
                _fieldColor23 = value;
                OnPropertyChanged(nameof(FieldColor23));
            }
        }

        private string _fieldColor24 = "black";
        public string FieldColor24
        {
            get => _fieldColor24;
            set
            {
                if (_fieldColor24 == value) return;
                _fieldColor24 = value;
                OnPropertyChanged(nameof(FieldColor24));
            }
        }

        private string _fieldColor25 = "black";
        public string FieldColor25
        {
            get => _fieldColor25;
            set
            {
                if (_fieldColor25 == value) return;
                _fieldColor25 = value;
                OnPropertyChanged(nameof(FieldColor25));
            }
        }

        private string _fieldColor26 = "black";
        public string FieldColor26
        {
            get => _fieldColor26;
            set
            {
                if (_fieldColor26 == value) return;
                _fieldColor26 = value;
                OnPropertyChanged(nameof(FieldColor26));
            }
        }

        private string _fieldColor27 = "black";
        public string FieldColor27
        {
            get => _fieldColor27;
            set
            {
                if (_fieldColor27 == value) return;
                _fieldColor27 = value;
                OnPropertyChanged(nameof(FieldColor27));
            }
        }

        private string _fieldColor28 = "black";
        public string FieldColor28
        {
            get => _fieldColor28;
            set
            {
                if (_fieldColor28 == value) return;
                _fieldColor28 = value;
                OnPropertyChanged(nameof(FieldColor28));
            }
        }

        private string _fieldColor29 = "black";
        public string FieldColor29
        {
            get => _fieldColor29;
            set
            {
                if (_fieldColor29 == value) return;
                _fieldColor29 = value;
                OnPropertyChanged(nameof(FieldColor29));
            }
        }

        private string _fieldColor30 = "black";
        public string FieldColor30
        {
            get => _fieldColor30;
            set
            {
                if (_fieldColor30 == value) return;
                _fieldColor30 = value;
                OnPropertyChanged(nameof(FieldColor30));
            }
        }

        private string _fieldColor31 = "black";
        public string FieldColor31
        {
            get => _fieldColor31;
            set
            {
                if (_fieldColor31 == value) return;
                _fieldColor31 = value;
                OnPropertyChanged(nameof(FieldColor31));
            }
        }

        private string _fieldColor32 = "black";
        public string FieldColor32
        {
            get => _fieldColor32;
            set
            {
                if (_fieldColor32 == value) return;
                _fieldColor32 = value;
                OnPropertyChanged(nameof(FieldColor32));
            }
        }

        private string _fieldColor33 = "black";
        public string FieldColor33
        {
            get => _fieldColor33;
            set
            {
                if (_fieldColor33 == value) return;
                _fieldColor33 = value;
                OnPropertyChanged(nameof(FieldColor33));
            }
        }

        private string _fieldColor34 = "black";
        public string FieldColor34
        {
            get => _fieldColor34;
            set
            {
                if (_fieldColor34 == value) return;
                _fieldColor34 = value;
                OnPropertyChanged(nameof(FieldColor34));
            }
        }

        private string _fieldColor35 = "black";
        public string FieldColor35
        {
            get => _fieldColor35;
            set
            {
                if (_fieldColor35 == value) return;
                _fieldColor35 = value;
                OnPropertyChanged(nameof(FieldColor35));
            }
        }


        private string _fieldColor36 = "black";
        public string FieldColor36
        {
            get => _fieldColor36;
            set
            {
                if (_fieldColor36 == value) return;
                _fieldColor36 = value;
                OnPropertyChanged(nameof(FieldColor36));
            }
        }

        private string _fieldColor37 = "black";
        public string FieldColor37
        {
            get => _fieldColor37;
            set
            {
                if (_fieldColor37 == value) return;
                _fieldColor37 = value;
                OnPropertyChanged(nameof(FieldColor37));
            }
        }

        private string _fieldColor38 = "black";
        public string FieldColor38
        {
            get => _fieldColor38;
            set
            {
                if (_fieldColor38 == value) return;
                _fieldColor38 = value;
                OnPropertyChanged(nameof(FieldColor38));
            }
        }

        private string _fieldColor39 = "black";
        public string FieldColor39
        {
            get => _fieldColor39;
            set
            {
                if (_fieldColor39 == value) return;
                _fieldColor39 = value;
                OnPropertyChanged(nameof(FieldColor39));
            }
        }

        private string _fieldColor40 = "black";
        public string FieldColor40
        {
            get => _fieldColor40;
            set
            {
                if (_fieldColor40 == value) return;
                _fieldColor40 = value;
                OnPropertyChanged(nameof(FieldColor40));
            }
        }

        private string _fieldColor41 = "black";
        public string FieldColor41
        {
            get => _fieldColor41;
            set
            {
                if (_fieldColor41 == value) return;
                _fieldColor41 = value;
                OnPropertyChanged(nameof(FieldColor41));
            }
        }

        private string _fieldColor42 = "black";
        public string FieldColor42
        {
            get => _fieldColor42;
            set
            {
                if (_fieldColor42 == value) return;
                _fieldColor42 = value;
                OnPropertyChanged(nameof(FieldColor42));
            }
        }

        private string _fieldColor43 = "black";
        public string FieldColor43
        {
            get => _fieldColor43;
            set
            {
                if (_fieldColor43 == value) return;
                _fieldColor43 = value;
                OnPropertyChanged(nameof(FieldColor43));
            }
        }

        private string _fieldColor44 = "black";
        public string FieldColor44
        {
            get => _fieldColor44;
            set
            {
                if (_fieldColor44 == value) return;
                _fieldColor44 = value;
                OnPropertyChanged(nameof(FieldColor44));
            }
        }

        private string _fieldColor45 = "black";
        public string FieldColor45
        {
            get => _fieldColor45;
            set
            {
                if (_fieldColor45 == value) return;
                _fieldColor45 = value;
                OnPropertyChanged(nameof(FieldColor45));
            }
        }

        private string _fieldColor46 = "black";
        public string FieldColor46
        {
            get => _fieldColor46;
            set
            {
                if (_fieldColor46 == value) return;
                _fieldColor46 = value;
                OnPropertyChanged(nameof(FieldColor46));
            }
        }

        private string _fieldColor47 = "black";
        public string FieldColor47
        {
            get => _fieldColor47;
            set
            {
                if (_fieldColor47 == value) return;
                _fieldColor47 = value;
                OnPropertyChanged(nameof(FieldColor47));
            }
        }

        private string _fieldColor48 = "black";
        public string FieldColor48
        {
            get => _fieldColor48;
            set
            {
                if (_fieldColor48 == value) return;
                _fieldColor48 = value;
                OnPropertyChanged(nameof(FieldColor48));
            }
        }

        private string _fieldColor49 = "black";
        public string FieldColor49
        {
            get => _fieldColor49;
            set
            {
                if (_fieldColor49 == value) return;
                _fieldColor49 = value;
                OnPropertyChanged(nameof(FieldColor49));
            }
        }

        private string _fieldColor50 = "black";
        public string FieldColor50
        {
            get => _fieldColor50;
            set
            {
                if (_fieldColor50 == value) return;
                _fieldColor50 = value;
                OnPropertyChanged(nameof(FieldColor50));
            }
        }

        private string _fieldColor51 = "black";
        public string FieldColor51
        {
            get => _fieldColor51;
            set
            {
                if (_fieldColor51 == value) return;
                _fieldColor51 = value;
                OnPropertyChanged(nameof(FieldColor51));
            }
        }

        private string _fieldColor52 = "black";
        public string FieldColor52
        {
            get => _fieldColor52;
            set
            {
                if (_fieldColor52 == value) return;
                _fieldColor52 = value;
                OnPropertyChanged(nameof(FieldColor52));
            }
        }

        private string _fieldColor53 = "black";
        public string FieldColor53
        {
            get => _fieldColor53;
            set
            {
                if (_fieldColor53 == value) return;
                _fieldColor53 = value;
                OnPropertyChanged(nameof(FieldColor53));
            }
        }

        private string _fieldColor54 = "black";
        public string FieldColor54
        {
            get => _fieldColor54;
            set
            {
                if (_fieldColor54 == value) return;
                _fieldColor54 = value;
                OnPropertyChanged(nameof(FieldColor54));
            }
        }

        private string _fieldColor55 = "black";
        public string FieldColor55
        {
            get => _fieldColor55;
            set
            {
                if (_fieldColor55 == value) return;
                _fieldColor55 = value;
                OnPropertyChanged(nameof(FieldColor55));
            }
        }

        private string _fieldColor56 = "black";
        public string FieldColor56
        {
            get => _fieldColor56;
            set
            {
                if (_fieldColor56 == value) return;
                _fieldColor56 = value;
                OnPropertyChanged(nameof(FieldColor56));
            }
        }

        private string _fieldColor57 = "black";
        public string FieldColor57
        {
            get => _fieldColor57;
            set
            {
                if (_fieldColor57 == value) return;
                _fieldColor57 = value;
                OnPropertyChanged(nameof(FieldColor57));
            }
        }

        private string _fieldColor58 = "black";
        public string FieldColor58
        {
            get => _fieldColor58;
            set
            {
                if (_fieldColor58 == value) return;
                _fieldColor58 = value;
                OnPropertyChanged(nameof(FieldColor58));
            }
        }

        private string _fieldColor59 = "black";
        public string FieldColor59
        {
            get => _fieldColor59;
            set
            {
                if (_fieldColor59 == value) return;
                _fieldColor59 = value;
                OnPropertyChanged(nameof(FieldColor59));
            }
        }

        private string _fieldColor60 = "black";
        public string FieldColor60
        {
            get => _fieldColor60;
            set
            {
                if (_fieldColor60 == value) return;
                _fieldColor60 = value;
                OnPropertyChanged(nameof(FieldColor60));
            }
        }

        private string _fieldColor61 = "black";
        public string FieldColor61
        {
            get => _fieldColor61;
            set
            {
                if (_fieldColor61 == value) return;
                _fieldColor61 = value;
                OnPropertyChanged(nameof(FieldColor61));
            }
        }

        private string _fieldColor62 = "black";
        public string FieldColor62
        {
            get => _fieldColor62;
            set
            {
                if (_fieldColor62 == value) return;
                _fieldColor62 = value;
                OnPropertyChanged(nameof(FieldColor62));
            }
        }

        private string _fieldColor63 = "black";
        public string FieldColor63
        {
            get => _fieldColor63;
            set
            {
                if (_fieldColor63 == value) return;
                _fieldColor63 = value;
                OnPropertyChanged(nameof(FieldColor63));
            }
        }

        private string _fieldColor64 = "black";
        public string FieldColor64
        {
            get => _fieldColor64;
            set
            {
                if (_fieldColor64 == value) return;
                _fieldColor64 = value;
                OnPropertyChanged(nameof(FieldColor64));
            }
        }

        private string _fieldColor65 = "black";
        public string FieldColor65
        {
            get => _fieldColor65;
            set
            {
                if (_fieldColor65 == value) return;
                _fieldColor65 = value;
                OnPropertyChanged(nameof(FieldColor65));
            }
        }

        private string _fieldColor66 = "black";
        public string FieldColor66
        {
            get => _fieldColor66;
            set
            {
                if (_fieldColor66 == value) return;
                _fieldColor66 = value;
                OnPropertyChanged(nameof(FieldColor66));
            }
        }

        private string _fieldColor67 = "black";
        public string FieldColor67
        {
            get => _fieldColor67;
            set
            {
                if (_fieldColor67 == value) return;
                _fieldColor67 = value;
                OnPropertyChanged(nameof(FieldColor67));
            }
        }

        private string _fieldColor68 = "black";
        public string FieldColor68
        {
            get => _fieldColor68;
            set
            {
                if (_fieldColor68 == value) return;
                _fieldColor68 = value;
                OnPropertyChanged(nameof(FieldColor68));
            }
        }

        private string _fieldColor69 = "black";
        public string FieldColor69
        {
            get => _fieldColor69;
            set
            {
                if (_fieldColor69 == value) return;
                _fieldColor69 = value;
                OnPropertyChanged(nameof(FieldColor69));
            }
        }

        private string _fieldColor70 = "black";
        public string FieldColor70
        {
            get => _fieldColor70;
            set
            {
                if (_fieldColor70 == value) return;
                _fieldColor70 = value;
                OnPropertyChanged(nameof(FieldColor70));
            }
        }

        private string _fieldColor71 = "black";
        public string FieldColor71
        {
            get => _fieldColor71;
            set
            {
                if (_fieldColor71 == value) return;
                _fieldColor71 = value;
                OnPropertyChanged(nameof(FieldColor71));
            }
        }

        private string _fieldColor72 = "black";
        public string FieldColor72
        {
            get => _fieldColor72;
            set
            {
                if (_fieldColor72 == value) return;
                _fieldColor72 = value;
                OnPropertyChanged(nameof(FieldColor72));
            }
        }

        private string _fieldColor73 = "black";
        public string FieldColor73
        {
            get => _fieldColor73;
            set
            {
                if (_fieldColor73 == value) return;
                _fieldColor73 = value;
                OnPropertyChanged(nameof(FieldColor73));
            }
        }

        private string _fieldColor74 = "black";
        public string FieldColor74
        {
            get => _fieldColor74;
            set
            {
                if (_fieldColor74 == value) return;
                _fieldColor74 = value;
                OnPropertyChanged(nameof(FieldColor74));
            }
        }

        private string _fieldColor75 = "black";
        public string FieldColor75
        {
            get => _fieldColor75;
            set
            {
                if (_fieldColor75 == value) return;
                _fieldColor75 = value;
                OnPropertyChanged(nameof(FieldColor75));
            }
        }

        private string _fieldColor76 = "black";
        public string FieldColor76
        {
            get => _fieldColor76;
            set
            {
                if (_fieldColor76 == value) return;
                _fieldColor76 = value;
                OnPropertyChanged(nameof(FieldColor76));
            }
        }

        private string _fieldColor77 = "black";
        public string FieldColor77
        {
            get => _fieldColor77;
            set
            {
                if (_fieldColor77 == value) return;
                _fieldColor77 = value;
                OnPropertyChanged(nameof(FieldColor77));
            }
        }

        private string _fieldColor78 = "black";
        public string FieldColor78
        {
            get => _fieldColor78;
            set
            {
                if (_fieldColor78 == value) return;
                _fieldColor78 = value;
                OnPropertyChanged(nameof(FieldColor78));
            }
        }

        private string _fieldColor79 = "black";
        public string FieldColor79
        {
            get => _fieldColor79;
            set
            {
                if (_fieldColor79 == value) return;
                _fieldColor79 = value;
                OnPropertyChanged(nameof(FieldColor79));
            }
        }

        private string _fieldColor80 = "black";
        public string FieldColor80
        {
            get => _fieldColor80;
            set
            {
                if (_fieldColor80 == value) return;
                _fieldColor80 = value;
                OnPropertyChanged(nameof(FieldColor80));
            }
        }

        private string _fieldColor81 = "black";
        public string FieldColor81
        {
            get => _fieldColor81;
            set
            {
                if (_fieldColor81 == value) return;
                _fieldColor81 = value;
                OnPropertyChanged(nameof(FieldColor81));
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

        private ICommand _reloadButtonCommand;

        public ICommand ReloadButtonCommand
        {
            get
            {
                _reloadButtonCommand=new Command<String>(Reload);
                return _reloadButtonCommand;
            }
        }

        private void Reload(string commandString)
        {
            sudokuManager.Loescher();
        }

        #endregion
    }
}
