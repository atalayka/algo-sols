using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //A, E, I, O, U vowels except y
        public static string Disemvowel(string str)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            foreach (char c in vowels)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (c == str[i])
                    {
                        str = str.Remove(i, 1);
                    }
                }
            }
            Console.WriteLine(str);

            //       return string.Join("", str.Where(c => !"aeiouAEIOU".Contains(c)));
            return str;
        }

        static void Main(string[] args)
        {
            Disemvowel("What are you, a communist?");
        }
    }
}

