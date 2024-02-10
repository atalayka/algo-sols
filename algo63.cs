using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {

       

        public static int[] humanYearsCatYearsDogYears(int humanYears)
        {
            int catYears = 0;
            int dogYears = 0;

            for (int i = 0; i <= humanYears; i++)
            {

                switch (i)
                {
                    case 1: catYears = 15; dogYears = 15; break;
                    case 2: catYears += 9; dogYears += 9; break;
                }
                if (i >= 3)
                {
                    catYears += 4; dogYears += 5;
                }
            }

            return new int[] { humanYears, catYears, dogYears };
        }

        static void Main(string[] args)
        {
            Console.WriteLine(humanYearsCatYearsDogYears(10));
        }
    }
}
