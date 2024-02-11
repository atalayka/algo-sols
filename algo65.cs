using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        public static int FindShort(string s)
        {
            string[] words = s.Split(' ');
            int shortest = words.Min(x => x.Length);
            return shortest;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindShort("turns out random test cases are easier than writing out basic ones"));
        }
    }
}
