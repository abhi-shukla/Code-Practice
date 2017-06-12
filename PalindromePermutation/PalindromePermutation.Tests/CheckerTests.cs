using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromePermutation;

namespace PalindromePermutation.Tests
{
    [TestClass]
    public class CheckerTests
    {
        [TestMethod]
        public void Checker_WithValidString_ShouldReturnTrue()
        {
            // Arrange
            var checker = new Checker();

            // Act
            var res = checker.IsPermutationOfPalindrome("tact coa");

            // Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Checker_WithInvalidString_ShouldReturnFalse()
        {
            // Arrange
            var checker = new Checker();

            // Act
            var res = checker.IsPermutationOfPalindrome("tact coaa");

            // Assert
            Assert.IsFalse(res);
        }
    }
}
