using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium;

namespace LeetCode.Test.MediumTest
{
    [TestClass]
    public class ReverseIntegerTest
    {
        private ReverseInteger _reverseInteger;

        [TestInitialize]
        public void Setup()
        {
            _reverseInteger = new ReverseInteger();
        }

        [TestMethod]
        public void GivenThreeDigitInt()
        {
            var result = _reverseInteger.Solution(123);
            Assert.AreEqual(result, 321);
        }

        [TestMethod]
        public void GivenTwoDigitInt()
        {
            var result = _reverseInteger.Solution(22);
            Assert.AreEqual(result, 22);
        }

        [TestMethod]
        public void GivenOneDigitInt()
        {
            var result = _reverseInteger.Solution(1);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void GivenNegativeDigitInt()
        {
            var result = _reverseInteger.Solution(-123);
            Assert.AreEqual(result, -321);
        }

        [TestMethod]
        public void GivenLongInt()
        {
            var result = _reverseInteger.Solution(1463847412);
            Assert.AreEqual(result, 2147483641);
        }

    }
}

