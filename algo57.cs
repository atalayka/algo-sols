using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //coin row problem
        public static int CoinRow(int[] coins)
        {
            int n = coins.Length;
            if (n <= 0) return 0;
            if (n == 1) return coins[0];

            //dp dizisi 1. indeksteki en büyük değeri tutacak
            var dp = new int[n];
            dp[0] = coins[0];
            dp[1] = Math.Max(coins[0], coins[1]);

            for (int i = 2; i < n; i++)
            {
                dp[i] = Math.Max(dp[i - 1], dp[i - 2] + coins[i]);
            }
            return dp[n - 1];
        }
        static void Main(string[] args)
        {
            int[] Coinrow = [2, 4, 6, 2, 5];
            Console.WriteLine(CoinRow(Coinrow));
        }
    }
}