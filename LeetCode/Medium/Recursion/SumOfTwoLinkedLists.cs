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

        private Node Sum(Node l1, Node l2, int carry, Node result)
        {
            // base case to check if there's nothing else left
            if (l1 == null && l2 == null)
            {
                // in cases when there's a carry
                // just append it at the very end
                if(carry > 0)
                {
                    return AppendElementToTheEnd(result, carry);
                }
                // else return the result
                return result;
            }

            // checking if one of the nodes is null
            if (l1 == null || l2 == null)
            {
                // figure out which node is null and
                // calculate sum and remainder
                var withValue = l1 ?? l2;
                var sum = withValue.Value + carry;
                int remainder =  sum % 10;

                // recursively calculate sum for the next node,
                // which will be the value of the node + carry of there's any
                return Sum(null, withValue.Next, sum / 10, AppendElementToTheEnd(result, remainder));
            }
            else
            {
                // case when two nodes have values
                var sum = l1.Value + l2.Value + carry;
                int remainder = sum % 10;

                // recursively pass values of both nodes, carry and append
                // new value at the end of the result
                return Sum(l1.Next, l2.Next, sum / 10 , AppendElementToTheEnd(result, remainder));
            }
        }

        // helper method to append value at the end of linked list
        private Node AppendElementToTheEnd(Node l1, int value)
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
