using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            // return peopleListInOut.Sum(entry => entry[0] - entry[1]);

            int result = 0;
            foreach (var item in peopleListInOut)
            {
                result += item[0] - item[1];
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int[]> peopleList = new List<int[]>() { new[] { 3, 0 }, new[] { 9, 1 }, new[] { 4, 10 }, new[] { 12, 2 }, new[] { 6, 1 }, new[] { 7, 10 } };
            Console.WriteLine(Number(peopleList)); // 17
        }
    }
}

