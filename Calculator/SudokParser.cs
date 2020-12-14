using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace Calculator
{
    class SudokParser
    {
        static int sudokuSquareLength = 9;
        private int[] puzzle = new int[sudokuSquareLength];

        public void ConvertJsonToSudokuArray()
        {
            string filename = @"Assets\SudokuStrings\sudokustring_01_beginner.json";
            using (StreamReader r = new StreamReader(filename))
            {
                string json = r.ReadToEnd();
            }
        }
        
    }
}
