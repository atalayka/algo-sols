using System;

public static class Kata
{
    public static string CountSheep(int n)
    {
        string murmur = "";
        for (int i = 1; i <= n; i++)
        {
            murmur += $"{i} sheep...";
        }
        return murmur;
    }
}