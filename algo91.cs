using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '+': return value1 + value2;
                case '-': return value1 - value2;
                case '*': return value1 * value2;
                case '/': return value1 / value2;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(basicOp('*', 2, 2));
        }
    }
}

