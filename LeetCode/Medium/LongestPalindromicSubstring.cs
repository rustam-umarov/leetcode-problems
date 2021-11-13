namespace LeetCode.Medium
{
    //###source: https://leetcode.com/problems/longest-palindromic-substring/

    public class LongestPalindromicSubstring
    {
        public string Solution(string s)
        {
            var palindrome = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                // keep right and left at the same pointer
                // to always have odd number of chars in substring
                // when moving -1 and +1
                var left = i;
                var right = i;

                SearchForPalindrome(left, right, ref palindrome, s);

                // keep right further for +1 for even palindromes
                left = i;
                right = i + 1;

                SearchForPalindrome(left, right, ref palindrome, s);
            }
            return palindrome;
        }

        private void SearchForPalindrome(int left, int right, ref string palindrome, string s)
        {
            // loop over string to make sure neighbors are equal
            // if they are extract that substring but subtracting
            // left(smallest pointer) from right(largest pointer)
            // and add 1, since index is always less 1 than count

            // if condition of while isn't satisfied will proceed to next
            // i in the sequence and keep looking for neighbors until palindrome
            // is found
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                // validate and record finding into palindrome variable
                if (right - left + 1 > palindrome.Length)
                {
                    palindrome = s.Substring(left, right - left + 1);
                }

                // in case we found and recorded palindrome,
                // expand counters to see if current palindrome can
                // be extended into bigger one
                left--;
                right++;
            }
        }
    }
}
