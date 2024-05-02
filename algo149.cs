using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;


namespace HelloWorld
{
    class Program
    {
        public static string Derive(double coefficient, double exponent)
        {
            return $"{coefficient * exponent:F0}x^{exponent - 1}";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Derive(7, 8));
        }
    }
}

