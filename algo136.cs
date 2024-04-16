using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace HelloWorld
{
    class Program
    {
        public static bool ValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\(\d{3}\) \d{3}-\d{4}$");
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ValidPhoneNumber("(123) 456-7890"));
        }
    }
}