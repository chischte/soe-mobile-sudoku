using SudokuApp.view;

namespace SudokuApp.Model
{
    public interface ISudokuManager
    {
        int[] GetSudokuIntArray();
        FieldColor[] GetFieldColorArray(int[] sudokuIntArray);
    }
}
