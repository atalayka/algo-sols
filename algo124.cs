using System;
using System.Linq;
using System.Collections;

namespace HelloWorld
{

    class Program
    {
        public static string OddOrEven(int[] array)
        {
            int result = 0;
            foreach (var item in array)
            {
                result += item;
            }
            return result % 2 == 0 ? "Even" : "Odd";
        }
        static void Main(string[] args)
        {
            int[] arr = { 123, 156, 6, 7, 27, 272435, 124 };

            Console.WriteLine(OddOrEven(arr));
        }
    }
}

