namespace LeetCode.Easy.Recursion
{
    public class Factorial
    {
        public int Solution(int number)
        {
            if(number > 0)
            {
                return number * Solution(number - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
