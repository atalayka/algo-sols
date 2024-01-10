using System;
using System.Linq;

public class Kata
{
    public static int MaxMultiply(int divisor, int bound)
    {
        var largestN = Enumerable.Range(1, bound)
            .Where(n => n % divisor == 0)
            .LastOrDefault();

        return largestN;
    }
}