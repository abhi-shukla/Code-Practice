using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringReplacement;

namespace StringReplacement.Tests
{
    [TestClass]
    public class ReplacerTests
    {
        [TestMethod]
        public void IsReplaceable_OnReplaceableString_ShouldReturnTrue()
        {
            // Arrange
            var replacer = new Replacer();

            // Act
            var res = replacer.IsReplaceable("pale", "bale");

            // Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IsReplaceable_OnEditableString_ShouldReturnTrue()
        {
            // Arrange
            var replacer = new Replacer();

            // Act
            var res = replacer.IsReplaceable("pale", "pales");

            // Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void IsReplaceable_OnNonReplaceableString_ShouldReturnTrue()
        {
            // Arrange
            var replacer = new Replacer();

            // Act
            var res = replacer.IsReplaceable("pale", "bae");

            // Assert
            Assert.IsFalse(res);
        }
    }
}
