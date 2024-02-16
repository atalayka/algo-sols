using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int Fincrement = Convert.ToInt32(p0 * (percent / 100));
            int result = p0 + Fincrement + aug;
            int years = 1;
            while (result < p)
            {
                result += Convert.ToInt32((result * percent / 100) + aug);
                years++;
            }
            Console.WriteLine(years);
            return years;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NbYear(1500, 5, 100, 5000)); //15
        }
    }
}
