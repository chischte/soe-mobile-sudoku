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
