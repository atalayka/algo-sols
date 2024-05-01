using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;


namespace HelloWorld
{
    class Program
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return ClassPoints.Sum() / ClassPoints.Length > YourPoints ? false : true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(BetterThanAverage(new int[] { 10, 20, 30, 40, 50, 60, 70, 80 }, 20));
        }
    }
}

