using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static string HighAndLow(string numbers)
        {
            List<string> strings = numbers.Split(" ").ToList();
            List<int> ints = new List<int>();

            foreach (var x in strings)
            {
                ints.Add(Convert.ToInt32(x));
            }
            int min = ints.Min();
            int max = ints.Max();
            return max.ToString() + " " + min.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
    }
}

