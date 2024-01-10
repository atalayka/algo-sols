using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {

        public class Algorithm
        {
            public static int vowelCount(string str){
        
             int count = str.Where(c => c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u').Count();
             return count;
            }
        }

        static void Main(string[] args)
        {
            string x = "abracadabra";
            Console.WriteLine(Algorithm.vowelCount(x));
        }
    }
}
