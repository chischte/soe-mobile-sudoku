using System;
using System.Collections.Generic;
using System.Text;

namespace SudokuApp.Solver
{
    class SudokuSolver
    {
        const int NumberOfSudokuFields = 81;
        const int SudokuSquareLength = 9;
        private int[,] sudokuToSolve;
        private int[,] solvedSudoku;
        private int gridSizeSudoku=9;
        private int row;
        private int col;

        public SudokuSolver()
        {
            this.solvedSudoku=new int[SudokuSquareLength,SudokuSquareLength];
            this.sudokuToSolve=new int[SudokuSquareLength,SudokuSquareLength];
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

            if (isSudokuFullyFilledOut(gridSizeSudoku, sudokuToSolve))
            {
                // this is the place where the solved sudoku goes to the Gui
                solvedSudoku = sudokuToSolve;

                return true;
            }
            else
            {
            search:
                {
                    // detect first empty field
                    for (int x = 0; x < gridSizeSudoku; x++)
                    {
                        for (int y = 0; y < gridSizeSudoku; y++)
                        {
                            if (sudokuToSolve[x,y] == 0)
                            {
                                rowsolver = x;
                                colsolver = y;
                                break;
                            }
                        }
                    }
                }

                row = rowsolver;
                col = colsolver;

                possibilityArraySolver = CheckAllTheSudokuRulesOfTheEntries();

                try
                {
                    // It needs to be equal to the size of the Sudoku length otherwise the last field could not be check by all the Sudoku rules
                    for (int i = 0; i < 10; i++)
                    {
                        if (isSudokuFullyFilledOut(gridSizeSudoku, sudokuToSolve))
                        {
                            break;
                        }

                        if (i < 9 && possibilityArraySolver[i] != 0)
                        {
                            sudokuToSolve[rowsolver,colsolver] = possibilityArraySolver[i];
                            // ToDo get out of the loop when solver returns true
                            solver();

                        }
                        else if (i == 8 || i == 9)
                        {
                            sudokuToSolve[rowsolver,colsolver] = 0;
                        }
                    }
                }
                catch (Exception e)
                {
                }
            }

            return false;
        }

        private int[] CheckAllTheSudokuRulesOfTheEntries()
        {
            int[] possibilityArray = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            // Check if the 3x3 Sudoku rule is valid
            possibilityArray = IsTheThreeByThreeRuleValid(getTheThreeByThreeGrid(row), getTheThreeByThreeGrid(col), possibilityArray);

            // Check if the horizontal row and if the vertical col is valid
            possibilityArray = checkIfHorizontalIsValid(possibilityArray, gridSizeSudoku);
            possibilityArray = checkIfVerticalIsValid(possibilityArray, gridSizeSudoku);

            // Change the array to the possible numbers
            possibilityArray = ChangeToPossibleNumbers(possibilityArray);

            return possibilityArray;
        }

        private int[] ChangeToPossibleNumbers(int[] possibilityArray)
        {
            int ConversionPossibilityArray = 1;
            for (int i = 0; i < gridSizeSudoku; i++)
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

        private int[] IsTheThreeByThreeRuleValid(int threeByThreeRow, int threeByThreeCol, int[] possibilityArray)
        {
            int loader;
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    loader = sudokuToSolve[threeByThreeRow + row, threeByThreeCol + col];

                    if (loader != 0)
                    {
                        for (int a = 1; a < 10; a++)
                        {
                            if (loader == a)
                            {
                                possibilityArray[a - 1] = 1;
                                break;
                            }
                        }
                    }
                }
            }

            return possibilityArray;
        }

        private int[] checkIfVerticalIsValid(int[] possibilityArray, int gridSize)
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (sudokuToSolve[i,col] == j)
                    {
                        possibilityArray[j - 1] = 1;
                    }
                }
            }

            return possibilityArray;
        }

        private bool isSudokuFullyFilledOut(int gridSize, int[,] loader)
        {
            for (int y = 0; y < gridSize; y++)
            {
                for (int x = 0; x < gridSize; x++)
                {
                    if (loader[x,y] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private int[] checkIfHorizontalIsValid(int[] possibilityArray, int gridSize)
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (sudokuToSolve[row,i] == j)
                    {
                        possibilityArray[j - 1] = 1;
                    }
                }
            }

            return possibilityArray;
        }

        private int getTheThreeByThreeGrid(int number)
        {
            if (number >= 0 && number <= 2)
            {
                return 0;
            }
            else if (number >= 3 && number <= 5)
            {
                return 3;
            }
            else
            {
                return 6;
            }
        }

    }
}
