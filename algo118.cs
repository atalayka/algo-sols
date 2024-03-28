using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HelloWorld
{

    class Program
    {
        public static string Greet(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Greet("Jack"));
        }
    }
}

