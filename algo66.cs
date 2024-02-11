using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        //Count the divisors of a number
        public static int Divisors(int n)
        {
            int divisorCount = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0){divisorCount++;}
            }
            return divisorCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Divisors(50000));
        }
    }
}
