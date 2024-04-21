using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace HelloWorld
{
    class Program
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            /* switch (flower1 % 2 == 1 && flower2 % 2 == 0 || flower1 % 2 == 0 && flower2 % 2 == 1 )
             {
                 case true: return true;
                 default: return false;
             }*/

            return (flower1 % 2 != flower2 % 2);

        }
        static void Main(string[] args)
        {
            Console.WriteLine(lovefunc(1, 2));
        }
    }
}