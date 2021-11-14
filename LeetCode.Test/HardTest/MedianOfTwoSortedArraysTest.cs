using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Hard;

namespace LeetCode.Test.HardTest
{
    [TestClass]
    public class MedianOfTwoSortedArraysTest
    {
        private MedianOfTwoSortedArrays _medianOfTwoSortedArrays;

        [TestInitialize]
        public void Setup()
        {
            _medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
        }

        public void GivenTwoSimpleSortedArrays()
        {
            var result = _medianOfTwoSortedArrays.Solution(new int[]{ 1, 2}, new int[]{ 3, 4 });
            Assert.AreEqual(2.5, result);
        }

        public void GivenUnequalArrays()
        {
            var result = _medianOfTwoSortedArrays.Solution(new int[] { 1, 3 }, new int[] { 2 });
            Assert.AreEqual(2, result);
        }

        public void GivenRepeatingNumbers()
        {
            var result = _medianOfTwoSortedArrays.Solution(new int[] { 1, 1 }, new int[] { 1, 2 });
            Assert.AreEqual(1, result);
        }
    }
}

