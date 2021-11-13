using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium;

namespace LeetCode.Test.MediumTest
{
    [TestClass]
    public class LongestPalindromicSubstringTest
    {
        private LongestPalindromicSubstring _longestPalindromicSubstring;

        [TestInitialize]
        public void Setup()
        {
            _longestPalindromicSubstring = new LongestPalindromicSubstring();
        }

        [TestMethod]
        public void GivenTripletPalindromicSubstring()
        {
            var result = _longestPalindromicSubstring.Solution("babad");
            Assert.AreEqual("bab", result);
        }

        [TestMethod]
        public void GivenRepeatingLetterPalindrom()
        {
            var result = _longestPalindromicSubstring.Solution("cbbd");
            Assert.AreEqual("bb", result);
        }

        [TestMethod]
        public void GivenOneLetterPalindrome()
        {
            var result = _longestPalindromicSubstring.Solution("a");
            Assert.AreEqual("a", result);
        }

        [TestMethod]
        public void GivenNoPalindromeString()
        {
            var result = _longestPalindromicSubstring.Solution("ac");
            Assert.AreEqual("a", result);
        }
    }
}

