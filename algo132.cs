using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace HelloWorld
{

    class Program
    {
        public static int FindDifference(int[] a, int[] b)
        {
            int result1 = 1;
            foreach (var item in a)
            {
                result1 *= item;
            }
            int result2 = 1;
            foreach (var item in b)
            {
                result2 *= item;
            }
            return Math.Abs(result1 - result2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindDifference(new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 }));
        }
    }
}
