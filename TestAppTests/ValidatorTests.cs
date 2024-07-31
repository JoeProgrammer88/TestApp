using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Tests
{
    [TestClass()]
    public class ValidatorTests
    {
        [TestMethod()]
        [DataRow(5, 1, 10)]
        [DataRow(1, 1, 10)]
        [DataRow(10, 1, 10)]
        public void IsWithinRangeTest(int valueToTest, int min, int max)
        {
            bool result = Validator.IsWithinRange(valueToTest, min, max);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        [DataRow(0, 1, 10)]
        [DataRow(11, 1, 10)]
        public void IsWithinRangeTestFail(int valueToTest, int min, int max)
        {
            bool result = Validator.IsWithinRange(valueToTest, min, max);
            Assert.AreEqual(false, result);
        }
    }
}