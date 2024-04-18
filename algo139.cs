using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace HelloWorld
{
    class Program
    {
        public static int[] Take(int[] arr, int n)
        {
            n = Math.Min(n, arr.Length);
            return arr[..n];
        }
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5, 6 };
            int y = 10;
            Console.WriteLine(Take(x, y));
        }
    }
}