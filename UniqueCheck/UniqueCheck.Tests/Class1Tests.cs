using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniqueCheck;

namespace UniqueCheck.Tests
{
    [TestClass]
    public class Class1Tests
    {
        [TestMethod]
        public void CheckUnique_ForValidString_ShouldReturnTrue()
        {
            // Arrange
            var class1 = new Class1();
            var input = "quickfox";

            // Act
            var res = class1.IsUnique(input);

            // Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void CheckUnique_ForInValidString_ShouldReturnFalse()
        {
            // Arrange
            var class1 = new Class1();
            var input = "quickk";

            // Act
            var res = class1.IsUnique(input);

            // Assert
            Assert.IsFalse(res);
        }
    }
}
