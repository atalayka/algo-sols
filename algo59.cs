using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int[] Between(int a, int b)
        {
         List<int> result = new List<int>();
            for (int i = a; i <= b; i++)
            {
                result.Add(i);
            }
            return result.ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Between(1,10));
        }
    }
}
