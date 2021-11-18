using System.Collections.Generic;
using System;

namespace LeetCode.Hard
{
    //###source: https://leetcode.com/problems/first-missing-positive/

    public class SmallestPositiveInteger
    {
        public int Solution(int[] nums)
        {
            var set = new SortedSet<int>();

            // add all items to set
            Array.ForEach(nums, x => set.Add(x));

            // smallest positive int is either any int
            // starting with 1 up to nums.Length,
            // otherwise max number from set + 1
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!set.Contains(i))
                {
                    return i;
                }
            }

            // no min int found in the beginning
            // returning max + 1 from set
            return set.Max + 1;
        }
    }
}
