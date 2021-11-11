using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy.Recursion;

namespace LeetCode.Test.EasyTest.Recursion
{
    [TestClass]
    public class FactorialTest
    {
        private Factorial _factorial;

        [TestInitialize]
        public void Setup()
        {
            _factorial = new Factorial();
        }

        //base case

        [TestMethod]
        public void GivenZeroReturnFactorial()
        {
            var result = _factorial.Solution(0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GivenOneReturnFactorial()
        {
            var result = _factorial.Solution(1);
            Assert.AreEqual(1, result);
        }

        //recursive case

        [TestMethod]
        public void GivenFourReturnFactorial()
        {
            var result = _factorial.Solution(4);
            Assert.AreEqual(24, result);
        }
    }
}
