using System;

public class Kata
{
    public static long FindNextSquare(long num)
    {
        long root = (long)Math.Sqrt(num);

        if (root * root == num)
        {
            return (root + 1) * (root + 1);
        }
        return -1;
    }
}

public static long FindNextSquare2(long num)
{
    long root = (long)Math.Sqrt(num);
    return root * root == num ? (root + 1) * (root + 1) : -1;
}