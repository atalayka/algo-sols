using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace HelloWorld
{

    class Program
    {
        public static string[] Capitalize(string s)
        {
            string evenCapitalize = "";
            string oddCapitalize = "";

            for (int i = 0; i < s.Length; i++)
            {

                if (i % 2 == 0)
                {
                    evenCapitalize += char.ToUpper(s[i]);
                    oddCapitalize += char.ToLower(s[i]);
                }
                else
                {
                    evenCapitalize += char.ToLower(s[i]);
                    oddCapitalize += char.ToUpper(s[i]);
                }
            }

            return new string[] { evenCapitalize, oddCapitalize };
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Capitalize("Hello, World!"));
        }
    }
}
