using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;

namespace LeetCode.Test
{
    [TestClass]
    public class TwoSumTest
    {
        private TwoSum _twoSum;

        [TestInitialize]
        public void Setup()
        {
            _twoSum = new TwoSum();
        }

        [TestMethod]
        public void GivenTwoSmallNumbersReturnsTheirSum()
        {
            var result = _twoSum.Solution(2, 2);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void GivenTwoLargeNumbersReturnsTheirSum()
        {
            var result = _twoSum.Solution(273864, 276441);
            Assert.AreEqual(550305, result);
        }
    }
}
