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
            int[,] twoDimensionalSudoku = GenerateTwoDimensionalArray(sudokuToSolve);
            int[] solvedSudoku = GenerateOneDimensionalArray(twoDimensionalSudoku);
            return solvedSudoku;
        }

        private int[,] GenerateTwoDimensionalArray(int[] oneDimensionalArray)
        {
            int[,] twoDimensionalArray = new int[SudokuSquareLength, SudokuSquareLength];
            int row = 0;
            int column = 0;
            for (int i = 0; i < NumberOfSudokuFields; i++)
            {
                twoDimensionalArray[row, column] = oneDimensionalArray[i];
                column++;
                if (column == SudokuSquareLength)
                {
                    row++;
                    column = 0;
                }
            }
            return twoDimensionalArray;
        }

        private int[] GenerateOneDimensionalArray(int[,] twoDimensionalArray)
        {
            int[] oneDimensionalArray = new int[NumberOfSudokuFields];
            int row = 0;
            int column = 0;
            for (int i = 0; i < NumberOfSudokuFields; i++)
            {
                oneDimensionalArray[i] = twoDimensionalArray[row, column];
                column++;
                if (column == SudokuSquareLength)
                {
                    row++;
                    column = 0;
                }

            }
            return oneDimensionalArray;
        }
    }
}
