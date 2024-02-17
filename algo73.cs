using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int GetSum(int a, int b)
        {
            int result = 0;
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    result += i;
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    result += i;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetSum(20, 10));
        }
    }
}
