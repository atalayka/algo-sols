using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static string ReverseLetter(string str)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string result = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (alphabet.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseLetter("atalay"));
        }
    }
}

