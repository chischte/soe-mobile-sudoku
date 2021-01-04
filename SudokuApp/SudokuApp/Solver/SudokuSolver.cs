using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuApp.Solver
{
    class SudokuSolver
    {
        const int NumberOfSudokuFields = 81;
        const int SudokuSquareLength = 9;

        public int[] GetSolvedSudoku(int[] sudokuToSolve)
        {


            int[] solvedSudoku = new int[NumberOfSudokuFields];
            return solvedSudoku;
        }

        private int[][] GenerateTwoDimensionalArray(int[] sudokuToSolve)
        {
            int[][] TwoDimensionalSudoku = new int[SudokuSquareLength][SudokuSquareLength];
            return TwoDimensionalSudoku;
        }
    }
}
