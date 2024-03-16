using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int RoundToNext5(int n)
        {
            if (n % 5 == 0) { return n; }
            else if (n < 0) { return n - n % 5; }
            else { return n + 5 - n % 5; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(RoundToNext5(247498)); // expected -247495
        }
    }
}

