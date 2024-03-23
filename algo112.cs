using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int DescendingOrder(int num)
        {
            /* return int.Parse(string.Concat(num.ToString().Select(c => c - '0').OrderByDescending(x => x)));*/
            List<int> ints = new List<int>();
            ints.Add(num % 10);
            while (num > 10)
            {
                num /= 10;
                ints.Add(num % 10);
            }
            ints.Sort();
            ints.Reverse();
            string result = string.Join("", ints);
            return Convert.ToInt32(result);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(113212357));
        }
    }
}

