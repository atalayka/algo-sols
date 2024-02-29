using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        public static int SumMix(object[] x)
        {
            int result = 0;
            foreach (var item in x)
            {
                result += Convert.ToInt32(item);
            }
            return result;
            //return x.Sum(item => Convert.ToInt32(item));
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumMix(["3", 6, 6, 0, "5", 8, 5, "6", 2, "0"]));
        }
    }
}

