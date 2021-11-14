using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy;

namespace LeetCode.Test.EasyTest
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
        public void GivenArrayWithFourElements()
        {
            var result = _twoSum.Solution(new int[]{2, 7, 11, 15}, 9);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(int[]));
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void GivenArrayWithThreeElements()
        {
            var result = _twoSum.Solution(new int[] { 3, 2, 4 }, 6);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(int[]));
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }


        [TestMethod]
        public void GivenArrayWithTwoElements()
        {
            var result = _twoSum.Solution(new int[] { 3, 3 }, 6);
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(int[]));
            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }
    }
}
