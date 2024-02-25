using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        public static string Longest(string s1, string s2)
        {
            string atoz = "abcdefghijklmnopqrstuvwxyz";
            string result = "";

            foreach (char c in atoz)
            {
                if (s1.Contains(c) || s2.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Longest("abcd", "xyz"));
        }
    }
}

