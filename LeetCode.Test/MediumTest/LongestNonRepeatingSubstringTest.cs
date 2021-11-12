using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium;

namespace LeetCode.Test.EasyTest
{
    [TestClass]
    public class LongestNonRepeatingSubstringTest
    {
        private LongestNonRepeatingSubstring _longestNonRepeatingSubstring;

        [TestInitialize]
        public void Setup()
        {
            _longestNonRepeatingSubstring = new LongestNonRepeatingSubstring();
        }

        [TestMethod]
        public void GivenSameLettersReturnLengthOne()
        {
            var result = _longestNonRepeatingSubstring.Solution("bbbbbbb");
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GivenRepeatingTripletReturnThree()
        {
            var result = _longestNonRepeatingSubstring.Solution("abcabcabc");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GivenComplexStringReturnThree()
        {
            var result = _longestNonRepeatingSubstring.Solution("pwwkew");
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GivenUniqueStringReturnLength()
        {
            var result = _longestNonRepeatingSubstring.Solution("au");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GivenStringWithRepeatingChar()
        {
            var result = _longestNonRepeatingSubstring.Solution("aab");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GivenRepeatingSubstring()
        {
            var result = _longestNonRepeatingSubstring.Solution("dvdf");
            Assert.AreEqual(3, result);
        }
    }
}

