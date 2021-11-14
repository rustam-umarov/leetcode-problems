using System.Collections.Generic;

namespace LeetCode.Easy
{
    public class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            var keys = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (keys.ContainsKey(target - nums[i]))
                {
                    return new int[2]
                    {
                    keys[target-nums[i]],
                    i
                    };
                }
                else
                {
                    keys.Add(nums[i], i);
                }
            }
            return new int[2] { -1, -1 };
        }
    }
}
