namespace LeetCode.Easy.Recursion
{
    public class Fibonacci
    {
        public int Solution(int number)
        {
            if(number > 2)
            {
                return Solution(number - 1) + Solution(number - 2); 
            }
            else
            {
                return 1;
            }
        }
    }
}
