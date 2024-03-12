using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static long MinValue(int[] a)
        {
            int[] figures = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string result = "";
            foreach (int fig in figures)
            {
                if (a.Contains(fig))
                {
                    result += fig;
                }
            }
            return Convert.ToInt64(result);
        }
        static void Main(string[] args)
        {
            int[] ints = [3, 6, 5, 5, 9, 8, 7, 6, 3, 5, 9];
            Console.WriteLine(MinValue(ints));
        }
    }
}

