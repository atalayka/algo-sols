using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        public static int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || input.Length == 0)
            {
                return new int[] {  }; // Return an empty array for null or empty input
            }

            int CPositive = 0; //
            int SNegative = 0;
            foreach (var inp in input)
            {
                if (inp > 0) { CPositive ++; }
                else { SNegative += inp; };
            }
            Console.WriteLine(CPositive + " " + SNegative);
            return new int[2] { CPositive, SNegative };
        }
        static void Main(string[] args)
        {
            int[] array = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            Console.WriteLine(CountPositivesSumNegatives(array));
        }
    }
}

