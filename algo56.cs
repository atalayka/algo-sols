using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static string ToAlternatingCase(string s)
        {
            string result = "";
            foreach (char c in s)
            {
                bool isUpper = char.IsUpper(c);  // İlk karakteri büyük olarak başlat
                if (isUpper)
                {
                    result += char.ToLower(c);
                }
                else
                {
                    result += char.ToUpper(c);
                }
                isUpper = !isUpper;  // Büyük/küçük harf durumunu değiştir
            }
            return result;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(ToAlternatingCase("ASdfASdfAsdf"));
        }

    }
}