using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        public class Algorithm
        {
            public static int SquareSum(int[] numbers)
            {
                int sum = 0;
                foreach (int number in numbers)
                {
                    int squaredNumber = number * number;
                    sum += squaredNumber;
                }
                return sum;
            }
        }
        public class Algorithm2
        {
            public static int SquareSum(int[] numbers)
            {
                return numbers.Aggregate(0, (sum, number) => sum + number * number);
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine(Algorithm.SquareSum(numbers));
            Console.WriteLine(Algorithm2.SquareSum(numbers));
        }
    }
}
