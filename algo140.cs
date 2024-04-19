using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace HelloWorld
{
    class Program
    {
        public static long[] SumDigPow(long a, long b)
        {
            List<long> result = new List<long>();
            List<long> range = new List<long>();

            for (long i = a; i < b; i++)
            {
                range.Add(i);
            }

            foreach (var x in range)
            {
                int digits = 1;
                double sum = 0;

                foreach (var y in x.ToString())
                {
                    sum += Math.Pow(Convert.ToInt32(y.ToString()), digits);
                    digits++;
                }
                if (sum == x)
                {
                    result.Add(x);
                }
            }
            return result.ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigPow(1, 100));
        }
    }
}