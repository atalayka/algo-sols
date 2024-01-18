using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        class Algorithm
        {
            public static int GetAge(string inputString)
            {
               return int.Parse(inputString[0].ToString());
            }
        }

        static void Main(string[] args)
        {
            string age = "3 years old";
            Console.WriteLine(Algorithm.GetAge(age));
        }
    }
}

