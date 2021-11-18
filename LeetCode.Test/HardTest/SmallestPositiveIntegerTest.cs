using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Hard;

namespace LeetCode.Test.HardTest
{
    [TestClass]
    public class SmallestPositiveIntegerTest
    {
        private SmallestPositiveInteger _medianOfTwoSortedArrays;

        [TestInitialize]
        public void Setup()
        {
            _medianOfTwoSortedArrays = new SmallestPositiveInteger();
        }

        [TestMethod]
        public void GivenArrayWithMissingNumberAtTheEnd()
        {
            var result = _medianOfTwoSortedArrays.Solution(new int[] { 1, 2, 0 });
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GivenArrayWithNegativeNumber()
        {
            var result = _medianOfTwoSortedArrays.Solution(new int[] { 3, 4, -1, 1 });
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GivenArrayWithMissingNumberInTheMiddle()
        {
            var result = _medianOfTwoSortedArrays.Solution(new int[] { 7, 8, 9, 11, 12 });
            Assert.AreEqual(1, result);
        }


        [TestMethod]
        public void GivenTwoNumbers()
        {
            var result = _medianOfTwoSortedArrays.Solution(new int[] { 2, 1});
            Assert.AreEqual(3, result);
        }
    }
}

