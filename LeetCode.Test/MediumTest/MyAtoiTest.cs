using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium;

namespace LeetCode.Test.MediumTest
{
    [TestClass]
    public class MyAtoiTest
    {
        private MyAtoi _myAtoi;

        [TestInitialize]
        public void Setup()
        {
            _myAtoi = new MyAtoi();
        }

        [TestMethod]
        public void GivenNegativeNumberWithLeadingWhiteSpace()
        {
            var result = _myAtoi.Solution(" -45");
            Assert.AreEqual(result, -45);
        }

        [TestMethod]
        public void GivenOutOfMaxNegativeInt()
        {
            var result = _myAtoi.Solution("-91283472332");
            Assert.AreEqual(result, -2147483648);
        }

        [TestMethod]
        public void GivenMultipleSignsInTheBeginning()
        {
            var result = _myAtoi.Solution("-+12");
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void GivenLongInt()
        {
            var result = _myAtoi.Solution("21474836460");
            Assert.AreEqual(result, 2147483647);
        }

        [TestMethod]
        public void GivenLongNonNegativeInt()
        {
            var result = _myAtoi.Solution("2147483646");
            Assert.AreEqual(result, 2147483646);
        }

        [TestMethod]
        public void GivenLongNegativeInt()
        {
            var result = _myAtoi.Solution("-2147483649");
            Assert.AreEqual(result, -2147483648);
        }
    }
}

