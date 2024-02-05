using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static string StringsSum(string s1, string s2)
        {

            int num1 = int.TryParse(s1 ?? "0", out num1) ? num1 : 0;
            int num2 = int.TryParse(s2 ?? "0", out num2) ? num2 : 0;
            //or return (num1 + num2).ToString();

            return (int.Parse(s1 ?? "0") + int.Parse(s2 ?? "0")).ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(StringsSum("11", "4"));
        }
    }
}