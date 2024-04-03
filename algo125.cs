using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWorld
{

    class Program
    {

        public static int SquareDigits(int n)
        {
            string numberAsString = n.ToString();
            string result = "";

            foreach (char digit in numberAsString)
            {
                int squaredDigit = (int)Math.Pow(int.Parse(digit.ToString()), 2);
                result += squaredDigit.ToString();
            }

            return int.Parse(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SquareDigits(9119));
        }
    }
}

