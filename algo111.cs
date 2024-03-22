using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static string FindNeedle(object[] haystack)
        {
            /* int index = haystack.ToList().IndexOf(needle);
             return index >= 0 ? $"found the needle at position {index}" : null;*/

            int i = 0;
            foreach (var item in haystack)
            {
                if (item == "needle")
                {
                    return $"found the needle at position {i}";
                }
                i++;
            }
            return null;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindNeedle(new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false }));
        }
    }
}

