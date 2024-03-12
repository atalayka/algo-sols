using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int CheckExam(string[] arr1, string[] arr2)
        {
            int counter = 0;
            int result = 0;
            foreach (var item in arr1)
            {
                if (item == arr2[counter])
                {
                    result += 4;
                }
                else if (arr2[counter] == "")
                {
                    result += 0;
                }
                else if (arr2[counter] != "" && item != arr2[counter])
                {
                    result -= 1;
                }
                counter++;
            }
            return Math.Max(result, 0);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CheckExam(new string[] { "b", "c", "b", "a" }, new string[] { "", "a", "a", "c" }));
        }
    }
}

