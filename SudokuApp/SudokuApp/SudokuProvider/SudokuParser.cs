using System.IO;
using Newtonsoft.Json.Linq;

namespace SudokuApp.SudokuProvider
{
    public class SudokuJson
    {
        public string puzzle { get; set; }
    }

    public class SudokuParser
    {
        static int sudokuSquareLength = 9;
        const int SudokuNumberOfFields = 81;

        private int[] sudokuArray = new int[SudokuNumberOfFields];

        public int[] GetSudokuArrayFromJson()
        {
            string fileName = @"Assets\SudokuStrings\sudokustring_01_beginner.json";

            StreamReader streamReader = new StreamReader(fileName);
            string jsonString = streamReader.ReadToEnd();

            JToken token = JObject.Parse(jsonString);

            string puzzleString = (string)token.SelectToken("puzzle");

            for (int i = 0; i < SudokuNumberOfFields; i++)
            {
                int.TryParse(puzzleString[i].ToString(), out sudokuArray[i]);
            }
            return sudokuArray;
        }
    }
}