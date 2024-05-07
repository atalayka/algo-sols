using System;

public class Kata
{
    public static int SumMul(int n, int m)
    {
        if (n <= 0 || m <= 0)
        {
            throw new ArgumentException("Both n and m must be positive integers.");
        }
        if (m <= n)
        {
            throw new ArgumentException("m must be greater than n.");
        }

        int sum = 0;
        for (int i = n; i < m; i += n)
        {
            sum += i;
        }
        return sum;
    }
}