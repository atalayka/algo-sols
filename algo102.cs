using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {

        public static string ToJadenCase(string phrase)
        {
            /* if (phrase == null || phrase.Length == 0)
             {
                 return phrase;
             }
             else
             {
                 return string.Join(" ", phrase.Split(' ').Select(word => char.ToUpper(word[0]) + word.Substring(1)));   
             }*/

            string[] words = phrase.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i][1..];
                }
            }

            return string.Join(" ", words);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ToJadenCase("How can mirrors be real if our eyes aren't real"));
        }
    }
}

