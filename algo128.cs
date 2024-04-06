using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace HelloWorld
{

    class Program
    {

        public static bool Xor(bool a, bool b)
        {
            return (a && !b) || (!a && b);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Xor(true, false));

        }
    }
}
