using System;
using System.Linq;
using System.Collections.Generic;
namespace HelloWorld
{
    class Program
    {
        public static string LargestGoodInteger(string num)
        {
            var largest = '0';
            var found = false;
            for (int i = 0; i < num.Length - 2; i++)
            {
                if (num[i] == num[i + 1] && num[i + 1] == num[i + 2])
                {
                    found = true;
                    largest = (char)Math.Max(largest, num[i]);
                }
            }
            return found ? new string(largest, 3): string.Empty;
        }

        static void Main(string[] args)
        {
            string nums = "6777133339";
            Console.WriteLine(LargestGoodInteger(nums));
        }
    }
}