﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Newtonsoft.Json;
using Calculator;
using Newtonsoft.Json.Linq;

namespace Calculator
{
    public class SudokuJson
    {
        public string puzzle { get; set; }
    }
}

public class SudokuParser
{
    static int sudokuSquareLength = 9;
    static int sudokuNumberOfFields = 81;
    private int[] sudokuArray = new int[sudokuNumberOfFields];

    public int[] GetSudokuArrayFromJson()
    {
        string fileName = @"Assets\SudokuStrings\sudokustring_01_beginner.json";

        StreamReader streamReader = new StreamReader(fileName);
        string jsonString = streamReader.ReadToEnd();

        JToken token = JObject.Parse(jsonString);

        string puzzleString = (string)token.SelectToken("puzzle");

        for (int i = 0; i < sudokuNumberOfFields; i++)
        {
            int.TryParse(puzzleString[i].ToString(), out sudokuArray[i]);
        }
        return sudokuArray;
    }
}
