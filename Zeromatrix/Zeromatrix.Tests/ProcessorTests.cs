using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zeromatrix;

namespace Zeromatrix.Tests
{
    [TestClass]
    public class ProcessorTests
    {
        [TestMethod]
        public void ZeroIn_OnMatrixWithZeros_ShouldNullifyColumnsAndRows()
        {
            // Arrange
            var matrix = new int[3, 3];
            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[0, 2] = 2;
            matrix[1, 0] = 7;
            matrix[1, 1] = 8;
            matrix[1, 2] = 3;
            matrix[2, 0] = 6;
            matrix[2, 1] = 5;
            matrix[2, 2] = 4;
            var processor = new Processor();

            // Act
            var res = processor.ZreoIn(matrix);

            // Assert
            
        }
    }
}
