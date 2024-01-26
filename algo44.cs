using System;
using System.Text.RegularExpressions;
namespace HelloWorld
{
    class Program
    {

        public class Kata
        {
            public static bool ValidatePin(string pin)
            {
                Regex regex = new Regex(@"^\d{4}$|^\d{6}$");
                return regex.IsMatch(pin) && (pin.Length == 4 || pin.Length == 6);
            }
        }



        static void Main(string[] args)
        {
            string pin = "1234 ";
            Console.WriteLine(Kata.ValidatePin(pin));
        }
    }
}   