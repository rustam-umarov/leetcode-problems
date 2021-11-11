using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Medium.Recursion;

namespace LeetCode.Test.MediumTest.Recursion
{
    [TestClass]
    public class SumOfTwoLinkedListsTest
    {
        private SumOfTwoLinkedLists _recursiveLinkedListSum;

        [TestInitialize]
        public void Setup()
        {
            _recursiveLinkedListSum = new SumOfTwoLinkedLists();
        }

        [TestMethod]
        public void GivenNumbersWithEqualLength()
        {
            var l1 = new Node
            {
                Value = 2,
                Next = new Node
                {
                    Value = 4,
                    Next = new Node
                    {
                        Value = 3,
                        Next = null
                    }
                }
            };

            var l2 = new Node
            {
                Value = 5,
                Next = new Node
                {
                    Value = 6,
                    Next = new Node
                    {
                        Value = 4,
                        Next = null
                    }
                }
            };

            var result = _recursiveLinkedListSum.Solution(l1, l2);

            int[] answer = { 7, 0, 8 };

            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], result.Value);
                result = result.Next;
            }
        }

        [TestMethod]
        public void GivenNumbersWithDifferentLength()
        {
            var l1 = new Node
            {
                Value = 9,
                Next = new Node
                {
                    Value = 9,
                    Next = new Node
                    {
                        Value = 9,
                        Next = null
                    }
                }
            };

            var l2 = new Node
            {
                Value = 1,
                Next = new Node
                {
                    Value = 6,
                    Next = new Node
                    {
                        Value = 9,
                        Next = new Node
                        {
                            Value = 2,
                            Next = null
                        }
                    }
                }
            };

            var result = _recursiveLinkedListSum.Solution(l1, l2);

            int[] answer = {0, 6, 9, 3};

            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], result.Value);
                result = result.Next;
            }
        }
    }
}
