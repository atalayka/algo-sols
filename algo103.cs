using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int CalculateYears(double principal, double interest, double tax, double desiredPrincipal)
        {
            int years = 0;
            while (principal <= desiredPrincipal && principal != desiredPrincipal)
            {
                double interestEarned = principal * interest;
                double taxDeducted = interestEarned * tax;
                principal += interestEarned - taxDeducted;
                years++;
            }
            return years;
        }
        static void Main(string[] args)
        {
            //should return 14 years.
            Console.WriteLine(CalculateYears(1000, 0.01625, 0.18, 1200));
        }
    }
}

