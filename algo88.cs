using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static string PrinterError(String s)
        {
            string sortedString = string.Concat(s.OrderBy(x => x));
            string alphabet = "abcdefghijklm";
            int counter = 0;

            foreach (var c in sortedString)
            {
                if (!alphabet.Contains(c))
                {
                    counter++;
                }
            }
            string result = $"{counter}/{s.Length}";
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PrinterError("aaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbmmmmmmmmmmmmmmmmmmmxyz"));
        }
    }
}

