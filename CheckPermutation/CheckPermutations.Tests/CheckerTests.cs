using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CheckPermutation;

namespace CheckPermutations.Tests
{
    [TestClass]
    public class CheckerTests
    {
        [TestMethod]
        public void CheckPermutationsV1_WithPermutations_ShouldReturnTrue()
        {
            // Arrange
            var checker = new Checker();

            // Act
            var res = checker.ArePermutationsV1("dog", "god");

            // Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void CheckPermutationsV1_WithNoPermutations_ShouldReturnFalse()
        {
            // Arrange
            var checker = new Checker();

            // Act
            var res = checker.ArePermutationsV1("doosdfg", "gfsdddf");

            // Assert
            Assert.IsFalse(res);
        }
    }
}
