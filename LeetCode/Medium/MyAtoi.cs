using System;
namespace LeetCode.Medium
{
    public class MyAtoi
    {
        public int Solution(string s)
        {
            // base case
            if(string.IsNullOrWhiteSpace(s))
            {
                return 0;
            }

            // remove trailing white spaces
            s = s.Trim();

            // we'll store the fact whether it's a
            // negative or positive number in 'm', eigher 1 or -1
            var m = s[0] == '-' ? -1 : s[0] == '+' ? 1 : 1;

            // initiating default result 
            var result = 0;

            // loop through all the chars in the string
            for (int i = 0; i < s.Length; i++)
            {
                // making sure we skip the sign at the beginning
                if(i == 0 && (s[i] == '-' || s[i] == '+'))
                {
                    continue;
                }

                // here we should know if char is a digit
                if (char.IsNumber(s[i]))
                {
                    // getting actual numerical value of char
                    var charNumericValue = (int)char.GetNumericValue(s[i]);

                    // important check that tells us if our result will be within boundaries
                    // of positive and negative int. Since negative is -...48 and positing is ...47
                    // we have to make sure that max value decreased 10 times should be before max or
                    // equal to max boundary. In cases when result and int.MaxValue/10 or int.MinValue/10
                    // are equal, we need to validate special case, where current char should be more
                    // than -8(negative case) or less than 7(positive case) - by doing this we will make sure
                    // that we are within boundaries, otherwise we return the max or min value respectively
                    if (m * result > int.MaxValue / 10 || m * result == int.MaxValue / 10 && m * charNumericValue > 7
                        || m * result < int.MinValue / 10 || m * result == int.MinValue / 10 && m * charNumericValue < -8)
                    {
                        return m > 0 ? int.MaxValue : int.MinValue;
                    }
                    else
                    {
                        // appending current char to the end of the result
                        // this is done after we made sure result won't overflow
                        result = result * 10 + charNumericValue;
                    }
                    // we need this continue here, because otherwise it will indicate
                    // that current char is not numeric and we will have to return
                    continue;
                }

                // we step here in case when char is not numeric
                // we might already have something in the result, or might not
                // therefore we do the check and convert to positive or negative
                // if necessary
                return result > 0 ? m * result : 0;
            }

            // we end up here in cases when the whole string is numeric
            // also we need to convert it to be positve or negative respectively
            return result * m;
        }
    }
}
