using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static String Accum(string s)
        {
            int IxCounter = 1;
            string Result = "";
            int lastIndexOfArray = s.Length - 1;

            foreach (char c in s)
            {
                Result += c.ToString().ToUpper();
                for (int i = 1; i < IxCounter; i++)
                {
                    Result += c.ToString().ToLower();
                }
                if (IxCounter != lastIndexOfArray + 1)
                {
                    Result += "-";
                }
                IxCounter++;
            }
            return Result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Accum("abcd"));
        }
    }
}

