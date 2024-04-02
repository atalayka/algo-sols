using System;
using System.Linq;
using System.Collections;

namespace HelloWorld
{

    class Program
    {
        public static bool Solution(string str, string ending)
        {
            if (ending.Length > str.Length)
            {
                return false;
            }
            else
            {
                return str.Substring(str.Length - ending.Length) == ending;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solution("Hello World", "World"));
        }
    }
}

