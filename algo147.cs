using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;


namespace HelloWorld
{
    class Program
    {
        public static int UnusualFive()
        {
            string str = "     ";
            return str.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(UnusualFive());
        }
    }
}

