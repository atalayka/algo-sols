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
        class Algorithm
        {
            public static bool IsSquare(int n)
            {
                int number = (int)Math.Sqrt(n);
                if (number * number == n)
                {
                    return true;
                }
                return false;
            }
            public static bool IsSquare2(int n)
            {
                if (n < 0)
                {
                    return false;
                }

                 return (int)(Math.Sqrt(n) ) * (int)(Math.Sqrt(n) ) == n;
            }
        }

        static void Main(string[] args)
        {
            int number = 25;
            Console.WriteLine(Algorithm.IsSquare(number));
            Console.WriteLine(Algorithm.IsSquare2(number));
        }
    }
}

