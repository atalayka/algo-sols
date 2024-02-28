using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        public static string dnaToRna(string dna)
        {
            string result = "";
            foreach (char c in dna)
            {
                switch (c)
                {
                    case 'U': result += "T"; break;
                    case 'T': result += "U"; break;
                    case 'G': result += "G"; break;
                    case 'C': result += "C"; break;
                    case 'A': result += "A"; break;
                    default: break;
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(dnaToRna("TTTT"));
        }
    }
}

