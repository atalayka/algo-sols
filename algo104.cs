using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int SumDigits(int number)
        {
            if (number < 0)
            {
                number *= -1;
            }
            string number2 = number.ToString();
            int result = 0;
            foreach (var c in number2)
            {
                result += int.Parse(c.ToString());
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumDigits(-32));
        }
    }
}

