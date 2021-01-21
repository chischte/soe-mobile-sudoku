using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuApp.Solver;

namespace SudokuApp
{
    [TestClass]

    public class SudokuSolverTests
    {
        private SudokuSolver testee;

        public SudokuSolverTests()
        {
            this.testee = new SudokuSolver();
        }

        [TestMethod]
        public void TestReturnSolvedSudoku()
        {
            // Arrange
            // The unsolved sudoku has three numbers missing.
            int[] unsolvedSudoku = new int[]
            {
                0,3,4,6,7,8,9,1,2,
                0,7,2,1,9,5,3,4,8,
                1,9,8,3,4,2,5,6,7,
                8,5,9,7,6,1,4,2,3,
                4,2,6,8,5,3,7,9,1,
                7,1,3,9,2,4,8,5,6,
                9,6,1,5,3,7,2,8,4,
                2,8,7,4,1,9,6,3,5,
                3,4,5,2,8,6,1,7,0

            };
            int expectedResultAtIndex0 = 5;
            int expectedResultAtIndex9 = 6;
            int expectedResultAtIndex80 = 9;


            // Act
            var resultSudoku = this.testee.GetSolvedSudoku(unsolvedSudoku);

            // Assert
            Assert.AreEqual(expectedResultAtIndex0, resultSudoku[0]);
            Assert.AreEqual(expectedResultAtIndex9, resultSudoku[9]);
            Assert.AreEqual(expectedResultAtIndex80, resultSudoku[80]);
        }
    }
}
