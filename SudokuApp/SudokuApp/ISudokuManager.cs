using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuApp
{
    public interface ISudokuManager
    {
        int[] GetSudokuIntArray();
        bool[] GetDuplicatesArray(int[] sudokuIntArray);
    }
}
