using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static long RowSumOddNumbers(long n)
        {

            int x = 1;
            long y = 0;
            for (int i = 1; i <= n; i++)
            {
                y = 0;
                for (int j = 0; j < i; j++)
                {
                    y += x;
                    x += 2;
                }
            }
            return y;
        }


        static void Main(string[] args)
        {
            long n = 42;
            Console.WriteLine(RowSumOddNumbers(n));

        }
    }
}
