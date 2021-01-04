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
        private int[,] solvedSudoku;
        private int currentFieldRow;
        private int currentFieldCol;

        public SudokuSolver()
        {
            this.solvedSudoku = new int[SudokuSquareLength, SudokuSquareLength];
            this.sudokuToSolve = new int[SudokuSquareLength, SudokuSquareLength];
        }


        public int[] GetSolvedSudoku(int[] sudokuToSolve)
        {
            int[,] twoDimensionalSudoku = GenerateTwoDimensionalArray(sudokuToSolve);
            this.sudokuToSolve = twoDimensionalSudoku;
            StartSolvingSudoku(this.sudokuToSolve);
            int[] solvedSudoku = GenerateOneDimensionalArray(twoDimensionalSudoku);
            return solvedSudoku;
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

        public int[,] StartSolvingSudoku(int[,] puzzleToSolve)
        {
            sudokuToSolve = puzzleToSolve;

            if (solver())
            {
                return solvedSudoku;
            }

            return sudokuToSolve;
        }

        public bool solver()
        {
            int rowsolver = 0;
            int colsolver = 0;
            int[] possibilityArraySolver = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            if (isSudokuFullyFilledOut(sudokuToSolve))
            {
                solvedSudoku = sudokuToSolve;
                return true;
            }

            {
                // detect first empty field
                for (int checkRow = 0; checkRow < SudokuSquareLength; checkRow++)
                {
                    for (int checkColumn = 0; checkColumn < SudokuSquareLength; checkColumn++)
                    {
                        if (sudokuToSolve[checkRow, checkColumn] == 0)
                        {
                            rowsolver = checkRow;
                            colsolver = checkColumn;
                            break;
                        }
                    }
                }
            }

            currentFieldRow = rowsolver;
            currentFieldCol = colsolver;

            possibilityArraySolver = CheckAllTheSudokuRulesOfTheEntries();
            {
                // It needs to be equal to the size of the Sudoku length otherwise the last field could not be check by all the Sudoku rules
                for (int i = 0; i < 10; i++)
                {
                    if (isSudokuFullyFilledOut(sudokuToSolve))
                    {
                        break;
                    }

                    if (i < 9 && possibilityArraySolver[i] != 0)
                    {
                        sudokuToSolve[rowsolver, colsolver] = possibilityArraySolver[i];
                        solver();

                    }
                    else if (i == 8 || i == 9)
                    {
                        sudokuToSolve[rowsolver, colsolver] = 0;
                    }
                }
            }

            return false;
        }

        //private void

        private int[] CheckAllTheSudokuRulesOfTheEntries()
        {
            int[] possibilityArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            //possibilityArray = SearchSectorPossibilities(getTheThreeByThreeGrid(currentFieldRow), getTheThreeByThreeGrid(currentFieldCol), possibilityArray);
            possibilityArray = SearchSectorPossibilities_V2(possibilityArray);
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

        private int[] SearchSectorPossibilities_V2(int[] possibilityArray)
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
