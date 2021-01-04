using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuApp.Solver
{
    class SudokuSolver
    {
        private const int NumberOfSudokuFields = 81;
        private const int SudokuSquareLength = 9;
        private int MaxFieldValue = 9;
        private int[,] sudokuToSolve;
        private int currentFieldRow;
        private int currentFieldCol;

        public int[] GetSolvedSudoku(int[] sudokuToSolve)
        {
            int[,] twoDimensionalSudoku = GenerateTwoDimensionalArray(sudokuToSolve);
            this.sudokuToSolve = twoDimensionalSudoku;
            RecursiveSolver();
            int[,] solverResult = this.sudokuToSolve;
            int[] oneDimensionalSolverResult = GenerateOneDimensionalArray(solverResult);
            return oneDimensionalSolverResult;
        }

        private int[,] GenerateTwoDimensionalArray(int[] oneDimensionalArray)
        {
            int[,] twoDimensionalArray = new int[SudokuSquareLength, SudokuSquareLength];
            int checkRow = 0;
            int checkColumn = 0;
            for (int i = 0; i < NumberOfSudokuFields; i++)
            {
                twoDimensionalArray[checkRow, checkColumn] = oneDimensionalArray[i];
                checkColumn++;
                if (checkColumn == SudokuSquareLength)
                {
                    checkRow++;
                    checkColumn = 0;
                }
            }
            return twoDimensionalArray;
        }

        private int[] GenerateOneDimensionalArray(int[,] twoDimensionalArray)
        {
            int[] oneDimensionalArray = new int[NumberOfSudokuFields];
            int checkRow = 0;
            int checkColumn = 0;
            for (int i = 0; i < NumberOfSudokuFields; i++)
            {
                oneDimensionalArray[i] = twoDimensionalArray[checkRow, checkColumn];
                checkColumn++;
                if (checkColumn == SudokuSquareLength)
                {
                    checkRow++;
                    checkColumn = 0;
                }
            }
            return oneDimensionalArray;
        }

        public bool RecursiveSolver()
        {
            int rowsolver = 0;
            int colsolver = 0;

            if (isSudokuFullyFilledOut(sudokuToSolve))
            {
                return true;
            }

            // Locate an empty field
            for (int checkRow = 0; checkRow < SudokuSquareLength; checkRow++)
            {
                for (int checkColumn = 0; checkColumn < SudokuSquareLength; checkColumn++)
                {
                    if (sudokuToSolve[checkRow, checkColumn] == 0)
                    {
                        rowsolver = checkRow;
                        colsolver = checkColumn;
                    }
                }
            }
            currentFieldRow = rowsolver;
            currentFieldCol = colsolver;

            int[] possibleFieldValues = GetPossibleNumbers();

            for (int i = 0; i <= possibleFieldValues.Length; i++)
            {
                if (isSudokuFullyFilledOut(sudokuToSolve))
                {
                    break;
                }
                if (i == 9)
                {
                    // No Possible number found!
                    // Set field zero and abort this recursion:
                    sudokuToSolve[rowsolver, colsolver] = 0;
                }
                else if (possibleFieldValues[i] != 0)
                {
                    // Assign value to current field and continue with the next field:
                    sudokuToSolve[rowsolver, colsolver] = possibleFieldValues[i];
                    RecursiveSolver();
                }

            }
            return false;
        }

        private int[] GetPossibleNumbers()
        {
            int[] possibilityArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            possibilityArray = SearchSectorPossibilities(possibilityArray);
            possibilityArray = SearchHorizontalPossibilities(possibilityArray);
            possibilityArray = SearchVerticalPossibilities(possibilityArray);
            possibilityArray = ChangeToPossibleNumbers(possibilityArray);

            return possibilityArray;
        }

        private int[] ChangeToPossibleNumbers(int[] possibilityArray)
        {
            int ConversionPossibilityArray = 1;
            for (int i = 0; i < SudokuSquareLength; i++)
            {
                if (possibilityArray[i] == 1)
                {
                    possibilityArray[i] = 0;
                }
                else
                {
                    possibilityArray[i] = ConversionPossibilityArray;
                }
                ConversionPossibilityArray++;
            }
            return possibilityArray;
        }

        private bool isSudokuFullyFilledOut(int[,] sudokuToSolve)
        {
            for (int row = 0; row < SudokuSquareLength; row++)
            {
                for (int column = 0; column < SudokuSquareLength; column++)
                {
                    if (sudokuToSolve[column, row] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private int[] SearchSectorPossibilities(int[] possibilityArray)
        {
            int sectorOfCurrentField = GetSector(currentFieldRow, currentFieldCol);
            for (int row = 0; row < SudokuSquareLength; row++)
            {
                for (int column = 0; column < SudokuSquareLength; column++)
                {
                    int compareValue = sudokuToSolve[row, column];
                    int compareSector = GetSector(row, column);
                    if (sectorOfCurrentField == compareSector && compareValue != 0)
                    {
                        possibilityArray[compareValue - 1] = 1;
                    }
                }
            }
            return possibilityArray;
        }

        private int GetSector(int row, int column)
        {
            int sector = 0;
            while (column > 2)
            {
                column -= 3;
                sector++;
            }

            while (row > 2)
            {
                row -= 3;
                sector += 3;
            }
            return sector;
        }

        private int[] SearchVerticalPossibilities(int[] possibilityArray)
        {
            for (int checkRow = 0; checkRow < SudokuSquareLength; checkRow++)
            {
                for (int possibilityArrayValue = 1; possibilityArrayValue < MaxFieldValue + 1; possibilityArrayValue++)
                {
                    if (sudokuToSolve[checkRow, currentFieldCol] == possibilityArrayValue)
                    {
                        possibilityArray[possibilityArrayValue - 1] = 1;
                    }
                }
            }

            return possibilityArray;
        }

        private int[] SearchHorizontalPossibilities(int[] possibilityArray)
        {
            for (int checkColumn = 0; checkColumn < SudokuSquareLength; checkColumn++)
            {
                for (int possibilityArrayValue = 1; possibilityArrayValue < MaxFieldValue + 1; possibilityArrayValue++)
                {
                    if (sudokuToSolve[currentFieldRow, checkColumn] == possibilityArrayValue)
                    {
                        possibilityArray[possibilityArrayValue - 1] = 1;
                    }
                }
            }

            return possibilityArray;
        }
    }
}
