using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static bool SmallEnough(int[] a, int limit)
        {
            foreach (int i in a)
            {
                if (i > limit)
                {
                    return false;
                }
                else { return true; }
            }
            return true;
            //return a.All(element => element <= limit);
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(SmallEnough(arr, 11));
        }
    }
}

