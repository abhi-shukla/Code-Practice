using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixSwap;

namespace MatrixSwap.Tests
{
    [TestClass]
    public class SwapperTests
    {
        [TestMethod]
        public void Swap_WithValidMatris_ShouldReturnTrue()
        {
            // Arrange
            var matrix = new int[3,3];
            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[0, 2] = 2;
            matrix[1, 0] = 7;
            matrix[1, 1] = 8;
            matrix[1, 2] = 3;
            matrix[2, 0] = 6;
            matrix[2, 1] = 5;
            matrix[2, 2] = 4;
            var swapper = new Swapper();

            // Act
            var res = swapper.Swap(matrix);

            // Assert
            Assert.IsTrue(res);
        }
    }
}
