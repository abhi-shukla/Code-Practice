using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCSharp
{
    [TestClass]
    public class ValueAndReferenceTypes
    {
        [TestMethod]
        public void TestReferenceAndValue()
        {
            // Arrange
            var emp = new Employee();
            emp.Id = 5;
            var someValue = 10;

            // Act
            ChangeValues(emp, out someValue);

            // Assert
            Assert.AreEqual(1, emp.Id);
            Assert.AreEqual(2, someValue);

        }

        void ChangeValues(Employee employee, out int value)
        {
            employee.Id = 1;
            value = 2;
        }
    }
}
