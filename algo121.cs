using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Formats.Asn1;
using System.Net.NetworkInformation;

namespace HelloWorld
{

    class Program
    {
        public static string PeopleWithAgeDrink(int old)
        {
            string drink;
            switch (old)
            {
                case int n when n < 14:
                    drink = "drink toddy";
                    break;
                case int n when n < 18:
                    drink = "drink coke";
                    break;
                case int n when n < 21:
                    drink = "drink beer";
                    break;
                default:
                    drink = "drink whisky";
                    break;
            }
            return drink;

        }

        static void Main(string[] args)
        {
            Console.WriteLine(PeopleWithAgeDrink(22));
        }
    }
}

