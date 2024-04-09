using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace HelloWorld
{

    class Program
    {
        public static string SwitchItUp(int number)
        {
            return number switch
            {
                1 => "One",
                2 => "Two",
                3 => "Three",
                4 => "Four",
                5 => "Five",
                6 => "Six",
                7 => "Seven",
                8 => "Eight",
                9 => "Nine",
                10 => "Ten",
                _ => "Invalid Number", // Default case for any number outside 1-10
            };
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SwitchItUp(1));
        }
    }
}
