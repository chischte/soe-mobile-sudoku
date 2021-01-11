using SudokuApp.view;
using System.Threading.Tasks;

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
        Task<string[]> GetNewSudokuArrayAsync();
        string[] GetNewSudokuStringArray();
        string[] GetCheckedStringArray(string[] sudokuStringArray);
        string[] GetSolvedSudoku(string[] sudokuStringArray);
        FieldColor[] GetFieldColorArray(string[] sudokuStringArray);
    }
}
