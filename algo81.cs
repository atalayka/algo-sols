using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        public static string Maskify(string cc)
        {
            string result = "";
            if (cc.Length > 4)
            {
                for (int i = 0; i < cc.Length - 4; i++)
                {
                    result += "#";
                }
                for (int j = cc.Length - 4; j < cc.Length; j++)
                {
                    result += cc[j];
                }
                return result;
            }
            return cc;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Maskify("23456789012345678901"));
        }
    }
}

