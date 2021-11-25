using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Hard
{
    public class MedianOfTwoSortedArrays
    {
        public double Solution(int[] nums1, int[] nums2)
        {
            // get sum of length of 2 arrays
            var length = nums1.Length + nums2.Length;
            var result = new double[length / 2 + 1];
            var isEven = length % 2 == 0;

            // find the smallest
            var largeArray = nums1.Length < nums2.Length ? nums2: nums1;
            var smallArray = nums1.Length < nums2.Length ? Array.ConvertAll<int, double>(nums1, x => x) : Array.ConvertAll<int, double>(nums2, x => x);

            if(nums1.Length == 0 || nums2.Length == 0)
            {
                if(nums1.Length == 0)
                {
                    result[0] = nums2[0];
                }
                else
                {
                    result[0] = nums1[0];
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                if(i == 0)
                {
                    continue;
                }

                var searchResult = i == largeArray.Length ? BinarySearch(result[i - 1], smallArray)
                    :  BinarySearch(largeArray[i], smallArray);

                if(i > largeArray.Length - 1)
                {
                    result[i] = searchResult ?? 0;
                }
                else if (largeArray[i] <= searchResult)
                {
                    result[i] = largeArray[i];
                }
                else
                {
                    result[i] = searchResult ?? 0;
                }


                if (i == result.Length - 1)
                {
                    if (isEven)
                    {
                        return (result.Last() + result[result.Length - 2]) / 2;
                    }
                    else
                    {
                        return result.Last();
                    }
                }
            }
            return 1;
        }


        private double? BinarySearch(double num, double[] nums)
        {
            int min = 0;
            int max = nums.Length - 1;
            double? temp = null;

            while (min <= max)
            {
                if (max - min == 1 || max - min == 0)
                {
                    return nums[min];
                }

                int mid = (min + max) / 2;
                if (num == nums[mid])
                {
                    temp = nums[++mid];
                }
                else if (num < nums[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return temp;
        }
    }
}
