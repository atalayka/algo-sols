using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        public static string DetermineCool(int incline, string name)
        {
            int AsciiSum = 0;
            foreach (char c in name)
            {
                AsciiSum += (int)c;
            }
            switch (incline)
            {
                case 2:
                    return Convert.ToString(AsciiSum, 2);
                case 8:
                    return Convert.ToString(AsciiSum, 8);
                case 10:
                    return AsciiSum.ToString();
                case 16:
                    return Convert.ToString(AsciiSum, 16).ToUpper();
            }

            return null;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(DetermineCool(16, "ThisIsADecimal"));
        }
    }
}

