namespace SudokuApp.Model
{
    public interface ISudokuManager
    {
        int[] GetSudokuIntArray();
        bool[] GetDuplicatesArray(int[] sudokuIntArray);
    }
}
