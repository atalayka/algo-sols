using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;


namespace HelloWorld
{
    class Program
    {
        public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        {

            if (enteredCode != correctCode) return false;
            else
            {
                int compare = DateTime.Compare(Convert.ToDateTime(currentDate), Convert.ToDateTime(expirationDate));
                if (compare < 0) return false;
                else { return true; }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CheckCoupon("123", "123", "September 5, 2014", "October 1, 2014"));
        }
    }
}


