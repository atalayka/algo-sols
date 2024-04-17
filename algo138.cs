using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace HelloWorld
{
    class Program
    {
        public static int DescendingOrder(int num)
        {
            return int.Parse(new string(num.ToString().OrderByDescending(x => x).ToArray()));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(124124));
        }
    }
}