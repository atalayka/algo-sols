using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public class Kata
        {
            public static object FirstNonConsecutive(int[] arr)
            {
                int counter = arr[0];

                foreach (var i in arr)
                {
                    if (i != counter)
                    { return i; }
                    counter++;
                }
                return null;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FirstNonConsecutive(new int[] { 1, 2, 3, 4, 6, 7, 8, 9, 10 }));
        }
    }
}

