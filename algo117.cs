using System;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HelloWorld
{
    class Program
    {
        public static string StringClean(string s)
        {
             return Regex.Replace(s, @"[0-9]", "");

              /*  foreach (char c in s)
            {
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                {
                    s = s.Replace(c.ToString(), "");
                }
            }
            return s;*/

         
        }
        static void Main(string[] args)
        {
            Console.WriteLine(StringClean("aspdfgmpasdfmg213mp"));
        }
    }
}

