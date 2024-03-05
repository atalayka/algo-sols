using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static string RemoveUrlAnchor(string url)
        {
            int index = url.IndexOf('#');
            return index != -1 ? url.Substring(0, index) : url;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RemoveUrlAnchor("https://www.codewars.com/kata/51f2b4448cadf20ed0000386/train/csharp#mustbetruncatedpartoftheprovidedstring"));
        }
    }
}

