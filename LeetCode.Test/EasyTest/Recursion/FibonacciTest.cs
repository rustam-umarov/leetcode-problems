using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Easy.Recursion;

namespace LeetCode.Test.EasyTest.Recursion
{
    [TestClass]
    public class FibonacciTest
    {
        private Fibonacci _fibonacci;

        [TestInitialize]
        public void Setup()
        {
            _fibonacci = new Fibonacci();
        }

        //recursive case

        [TestMethod]
        public void GivenFifthNumberReturnFive()
        {
            var result = _fibonacci.Solution(5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void GivenSixthNumberReturnEight ()
        {
            var result = _fibonacci.Solution(6);
            Assert.AreEqual(8, result);
        }

        //base case

        [TestMethod]
        public void GivenZeroReturnFibonacci()
        {
            var result = _fibonacci.Solution(0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GivenOneReturnFibonacci()
        {
            var result = _fibonacci.Solution(1);
            Assert.AreEqual(1, result);
        }
    }
}
