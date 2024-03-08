using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {

        public static string NameShuffler(string str)
        {
            var parts = str.Split(' ');
            return parts[1] + " " + parts[0];
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NameShuffler("Jane Doe"));
        }
    }
}

