namespace LeetCode.Medium.Recursion
{
    //###source: https://leetcode.com/problems/add-two-numbers/
    //Definition of node

    public class Node
    {
        public Node Next { get; set; }
        public int Value { get; set; }
    }

    public class SumOfTwoLinkedLists
    {
        public Node Solution(Node l1, Node l2)
        {
            return Sum(l1, l2, 0, null);
        }

        public Node Sum(Node l1, Node l2, int carry, Node result)
        {
            if (l1 == null && l2 == null)
            {
                if(carry > 0)
                {
                    return AppendElementToTheEnd(result, carry);
                }
                return result;
            }

            if (l1 == null || l2 == null)
            {
                var withValue = l1 ?? l2;
                var sum = withValue.Value + carry;
                int remainder =  sum % 10;

                return Sum(null, withValue.Next, sum / 10, AppendElementToTheEnd(result, remainder));
            }
            else
            {
                var sum = l1.Value + l2.Value + carry;
                int remainder = sum % 10;

                return Sum(l1.Next, l2.Next, sum / 10 , AppendElementToTheEnd(result, remainder));
            }
        }

        public Node AppendElementToTheEnd(Node l1, int value)
        {
            if (l1 == null)
            {
                return new Node
                {
                    Value = value
                };
            }

            var head = l1;

            while(head.Next != null)
            {
                head = head.Next;
            }

            head.Next = new Node
            {
                Value = value,
                Next = null
            };

            return l1;
        }
    }
}
