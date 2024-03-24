using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int Angle(int n)
        {
            return (n-2) * 180;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Angle(3));
        }
    }
}

