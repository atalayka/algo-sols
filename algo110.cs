using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int TwiceAsOld(int dadYears, int sonYears)
        {
            int x = sonYears * 2;
            int y = dadYears - x;
            return Math.Abs(y);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(TwiceAsOld(30, 7));
        }
    }
}

