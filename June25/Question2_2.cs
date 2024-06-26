namespace Main;

public class Question2_2
{
    // n should greater than 0
    public static int Fibonacci(int n)
    {
        int[] dp = new int[n+1];
        dp[0] = 0;
        dp[1] = 1;

        for (int i = 2; i <= n; i++)
        {
            dp[i] = dp[i-1] + dp[i-2];
        }

        return dp[n];
    }
}