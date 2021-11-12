namespace LeetCode.Medium
{
    //####source: https://leetcode.com/problems/longest-substring-without-repeating-characters/

    public class LongestNonRepeatingSubstring
    {
        public int Solution(string s)
        {
            var result = "";
            var temp = "";

            // base cases
            if(s.Length == 1)
            {
                return 1;
            }
            else if(s.Length == 0)
            {
                return 0;
            }

            // special case
            for (int i = 0; i < s.Length; i++)
            {
                // check if char is a repeating char
                if(temp.Contains(s[i]))
                {
                    // only assign to the result if temp.Length
                    // is more that result.Length
                    // this would indicate that we found a longer
                    // substring than we had before in result
                    if(temp.Length > result.Length)
                    {
                        result = temp;
                    }
                    // find index of repeating item in temp
                    var index = temp.IndexOf(s[i]) + 1;

                    // take all chars starting from repeating item
                    // to form a new substring, which might be longer
                    // than the one we already found
                    temp = temp.Substring(index, temp.Length - index) + s[i];
                    continue;
                }
                //we are good to add current char as it is unique
                temp += s[i];
            }

            // in cases where the whole string is unique
            // we don't assign value of temp to result
            // thus we need to return temp instead of result
            if(temp.Length > result.Length)
            {
                return temp.Length;
            }
            return result.Length;
        }
    }
}
