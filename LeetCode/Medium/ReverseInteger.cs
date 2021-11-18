using System;
namespace LeetCode.Medium
{
    //####source: https://leetcode.com/problems/reverse-integer/

    public class ReverseInteger
    {
        public int Solution(int x)
        {
            var result = 0;
            // keeping track of negative here to be
            // able to convert it back at the end

            var isNegative = x < 0;
            // algorithm works with positive numbers
            // in case x is negative, we muultiply it
            // by -1 to make it positive, then convert it 
            // back to its original state at the end
            x = x < 0 ? x * -1 : x; 

            while (x > 0)
            {
                // get remainder after division by 10
                var digit = x % 10;

                // decrease the length of x by dividing by 10
                x /= 10;

                // checking if our result is going to be within int range
                // after appending a new digit. Important: make sure to ceil
                // to top value after division, otherwise some edge cases might fail
                // e.g. 1463847412
                if (result > Math.Ceiling((decimal)int.MaxValue / 10) - digit)
                {
                    // we are out of int boundaries
                    return 0;
                }
                else
                {
                    // perform reverse of checking and append finding to result
                    result = result * 10 + digit;
                }
            }

            // if given number was negative, convert it back
            // otherwise return the original value of result
            return isNegative ? result * -1 : result ;
        }
    }
}
