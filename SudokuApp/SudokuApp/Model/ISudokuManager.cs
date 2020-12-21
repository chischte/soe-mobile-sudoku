using SudokuApp.view;

namespace SudokuApp.Model
{
    public enum FieldColor
    {
        Black = 0, // Neutral Color
        Red = 1,   // Duplicates
        Green = 2, // Signalize Sudoku Solved
    }

    public interface ISudokuManager
    {
       string[] GetNewSudokuStringArray();
        string[] GetCheckedStringArray(string[] sudokuStringArray);
       FieldColor[] GetFieldColorArray(string[] sudokuStringArray);
    }
}
