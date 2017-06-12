using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReplaceTheSpace;

namespace ReplaceTheSpace.Tests
{
    [TestClass]
    public class ReplacerTests
    {
        [TestMethod]
        public void Replacer_WithNoSpace_ShouldReturnSameString()
        {
            // Arrange
            var replacer = new Replacer();

            // Act
            var res = replacer.ReplaceSpace("testnospace");

            // Assert
            Assert.AreEqual("testnospace", res);
        }

        [TestMethod]
        public void Replacer_WithSpace_ShouldReturnUpdatedString()
        {
            // Arrange
            var replacer = new Replacer();

            // Act
            var res = replacer.ReplaceSpace("test with space");

            // Assert
            Assert.AreEqual("test%20with%20space", res);
        }
    }
}
