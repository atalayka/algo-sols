using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static string Solve(string s)
        {
            /* int lowercaseCount = s.Count(char.IsLower);
            int uppercaseCount = s.Count(char.IsUpper);
            */
            int lowercase = 0;
            int uppercase = 0;
            foreach (var item in s)
            {
                if (Char.IsLower(item))
                {
                    lowercase++;
                }
                else { uppercase++; }
            }
            return lowercase >= uppercase ? s.ToLower() : s.ToUpper();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solve("Code"));
        }
    }
}

