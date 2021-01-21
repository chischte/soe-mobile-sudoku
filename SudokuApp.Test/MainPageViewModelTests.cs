using System;
using System.Collections.Generic;
using System.Text;
using SudokuApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace SudokuApp
{
    [TestClass]
    public class MainPageViewModelTests
    {
        private readonly Mock<ISudokuManager> sudokuMock;
        private readonly ViewModel.MainPageViewModel testee;

        public MainPageViewModelTests()
        {
            this.sudokuMock = new Mock<ISudokuManager>(MockBehavior.Loose);
            this.testee = new ViewModel.MainPageViewModel(sudokuMock.Object);
        }

        [TestMethod]
        public void SetLoadCommand_CallsCorrespondingMethod()
        {
            // Arrange

            // Act
            this.testee.LoadButtonCommand.Execute("");

            // Assert
            this.sudokuMock.Verify(m => m.GetNewSudokuArrayAsync(), Times.Once);

        }

        [TestMethod]
        public void SetCheckCommand_CallsCorrespondingMethod()
        {
            // Arrange
            string[] sudokuStringArray = new string[81];
            for (int i = 0; i < sudokuStringArray.Length; i++)
            {
                sudokuStringArray[i] = "";
            }

            // Act
            this.testee.CheckButtonCommand.Execute("");

            // Assert
            this.sudokuMock.Verify(m => m.GetCheckedStringArray(sudokuStringArray), Times.Once);
        }
    }
}
