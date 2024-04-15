using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace HelloWorld
{
    class Program
    {
        public static string GetMiddle(string s)
        {
            if (s.Length % 2 == 0)
            {
                return s.Substring(s.Length / 2 - 1, 2);
            }
            else
            {
                return s.Substring(s.Length / 2, 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle("test"));
        }
    }
}