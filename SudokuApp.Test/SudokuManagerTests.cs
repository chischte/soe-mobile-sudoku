using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuApp.Model;

namespace SudokuApp
{
    [TestClass]
    public class SudokuManagerTests
    {
        private SudokuManager testee;
        const int NumberOfSudokuFields = 81;

        public SudokuManagerTests()
        {
            this.testee = new SudokuManager();
        }

        [TestMethod]
        public void TestRemoveInvalidEntriesFromStringArray()
        {
            // Arrange
            string[] inputStringArray = new string[NumberOfSudokuFields];
            // Add invalid entries to string array:
            inputStringArray[0] = "AA";
            inputStringArray[11] = "20";
            inputStringArray[22] = "-2";
            inputStringArray[33] = "0";
            inputStringArray[44] = " ";


            string expectedResult = "";

            // Act
            var result = this.testee.GetCheckedStringArray(inputStringArray);

            // Assert
            Assert.AreEqual(expectedResult, result[0]);
            Assert.AreEqual(expectedResult, result[11]);
            Assert.AreEqual(expectedResult, result[22]);
            Assert.AreEqual(expectedResult, result[33]);
            Assert.AreEqual(expectedResult, result[44]);
        }

        [TestMethod]
        public void TestFindDuplicatesInRow()
        {
            /*
             --------------------------------
             |      SUDOKU ARRAY GRID       |
             --------------------------------
             R=Row / C=Column / S=Sector

               |C1 C2 C3  C4 C5 C6  C7 C8 C9|
               |S1--------S2--------S3------|
             R1| 0  1  2 | 3  4  5 | 6  7  8|
             R2| 9 10 11 |12 13 14 |15 16 17|
             R3|18 19 20 |21 22 23 |24 25 26|
               |S4-------|S5-------|S6------|
             R4|27 28 29 |30 31 32 |33 34 35|
             R5|36 37 38 |39 40 41 |42 43 44|
             R6|45 46 47 |48 49 50 |51 52 53|
               |S7-------|S8-------|S9------|
             R7|54 55 56 |57 58 59 |60 61 62|
             R8|63 64 65 |66 67 68 |69 70 71|
             R9|72 73 74 |75 76 77 |78 79 80|
               |----------------------------| 

            */


            // Arrange
            string[] inputStringArray = new string[NumberOfSudokuFields];

            // Add duplicates to string array:
            inputStringArray[0] = "5";  // Sector 1 / Row 1 / Column 1
            inputStringArray[3] = "5";  // Sector 2 / Row 1 / Column 4
            inputStringArray[6] = "5";  // Sector 3 / Row 1 / Column 7

            inputStringArray[64] = "7"; // Sector 7 / Row 8 / Column 2
            inputStringArray[67] = "7"; // Sector 8 / Row 8 / Column 5
            inputStringArray[70] = "7"; // Sector 9 / Row 8 / Column 8

            inputStringArray[38] = "7"; // Sector 4 / Row 5 / Column 3 -> not a duplicate

            FieldColor expectedResultDuplicate = FieldColor.Red; // Duplicates are marked red
            FieldColor expectedResultNoDuplicate = FieldColor.Black; // Non-duplicates remain black

            // Act
            var result = this.testee.GetFieldColorArray(inputStringArray);

            // Assert
            Assert.AreEqual(expectedResultDuplicate, result[0]);
            Assert.AreEqual(expectedResultDuplicate, result[3]);
            Assert.AreEqual(expectedResultDuplicate, result[6]);
            Assert.AreEqual(expectedResultDuplicate, result[64]);
            Assert.AreEqual(expectedResultDuplicate, result[67]);
            Assert.AreEqual(expectedResultDuplicate, result[70]);
            Assert.AreEqual(expectedResultNoDuplicate, result[38]);
        }

        [TestMethod]
        public void TestFindDuplicatesInColumn()
        {
            // Arrange
            string[] inputStringArray = new string[NumberOfSudokuFields];

            // Add duplicates to string array:
            inputStringArray[0] = "5";  // Sector 1 / Row 1 / Column 1
            inputStringArray[27] = "5"; // Sector 4 / Row 4 / Column 1
            inputStringArray[54] = "5"; // Sector 7 / Row 7 / Column 1

            inputStringArray[14] = "7"; // Sector 2 / Row 2 / Column 6
            inputStringArray[41] = "7"; // Sector 5 / Row 5 / Column 6
            inputStringArray[68] = "7"; // Sector 8 / Row 8 / Column 6

            inputStringArray[47] = "7"; // Sector 4 / Row 6 / Column 3 -> not a duplicate

            FieldColor expectedResultDuplicate = FieldColor.Red; // Duplicates are marked red
            FieldColor expectedResultNoDuplicate = FieldColor.Black; // Non-duplicates remain black

            // Act
            var result = this.testee.GetFieldColorArray(inputStringArray);

            // Assert
            Assert.AreEqual(expectedResultDuplicate, result[0]);
            Assert.AreEqual(expectedResultDuplicate, result[27]);
            Assert.AreEqual(expectedResultDuplicate, result[54]);
            Assert.AreEqual(expectedResultDuplicate, result[14]);
            Assert.AreEqual(expectedResultDuplicate, result[14]);
            Assert.AreEqual(expectedResultDuplicate, result[68]);
            Assert.AreEqual(expectedResultNoDuplicate, result[47]);
        }


        [TestMethod]
        public void TestFindDuplicatesInSector()
        {
            // Arrange
            string[] inputStringArray = new string[NumberOfSudokuFields];

            // Add duplicates to string array:
            inputStringArray[0] = "5";  // Sector 1 / Row 1 / Column 1
            inputStringArray[10] = "5"; // Sector 1 / Row 2 / Column 2

            inputStringArray[60] = "7"; // Sector 9 / Row 7 / Column 7
            inputStringArray[70] = "7"; // Sector 9 / Row 8 / Column 8
            inputStringArray[50] = "7"; // Sector 5 -> not a duplicate


            FieldColor expectedResultDuplicate = FieldColor.Red; // Duplicates are marked red
            FieldColor expectedResultNoDuplicate = FieldColor.Black; // Non-duplicates remain black

            // Act
            var result = this.testee.GetFieldColorArray(inputStringArray);

            // Assert
            Assert.AreEqual(expectedResultDuplicate, result[0]);
            Assert.AreEqual(expectedResultDuplicate, result[10]);
            Assert.AreEqual(expectedResultDuplicate, result[60]);
            Assert.AreEqual(expectedResultDuplicate, result[70]);
            Assert.AreEqual(expectedResultNoDuplicate, result[50]);
        }




    }
}
