using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuApp.Model;

namespace SudokuApp
{
    [TestClass]
    public class SudokuManagerTests
    {
        private SudokuManager testee;

        public SudokuManagerTests()
        {
            this.testee=new SudokuManager();
        }

        [TestMethod]
        public void TestRemoveZerosFromStringArray()
        {
            // Arrange
            string[] inputStringArray = new string[]
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19",
                "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36",
                "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53",
                "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70",
                "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81"
            };

            string[] expectedResultArray = inputStringArray;

            for (int i = 9; i < 81; i++)
            {
                expectedResultArray[i] = "";

            }


            // Act
            var result = this.testee.GetCheckedStringArray(inputStringArray);

            // Assert
            Assert.AreEqual(expectedResultArray[10], result[10]);

        }

        [TestMethod]
        public void TestReturnSameNumber()
        {
            // Arrange
            int inputNumber = 555;

            int expectedResult = 555;

            // Act
            var result = this.testee.ReturnSameNumber(inputNumber);

            // Assert
            Assert.AreEqual(expectedResult, result);

        }
    }
}
