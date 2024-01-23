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
        public class Algorithm
        {
            public static string Solution(string str)
            {
                string result = "";
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    result += str[i];
                }
                return result;
            }
            public static string Solution2(string str)
            {
                if (str == null)
                {
                    return "";
                }

                // Optimized reversal using LINQ
                return new string(str.Reverse().ToArray());
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Algorithm.Solution("world"));
            Console.WriteLine(Algorithm.Solution2("world"));
        }
    }

}