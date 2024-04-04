using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWorld
{

    class Program
    {
        public static ulong factorial(int n)
        {
            int result = 1;
            for (int i = n; i > 1; i--)
            {
                result *= i;
            }
            return (ulong)result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
        }
    }
}

