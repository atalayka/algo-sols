using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static double Arithmetic(double a, double b, string op)
        {
            switch (op)
            {
                case "add": return a + b;
                case "substract": return a - b;
                case "multiply": return a * b;
                case "divide": return a / b;
            }
            throw new NotImplementedException();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Arithmetic(1, 2, "divide"));
        }
    }
}

