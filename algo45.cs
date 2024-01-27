using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = [2, 1, 3, 5, 4, 7, 6];
            int k = 3;

            List<int> numbers = [];

            int counter = 1;
            for (int i = 0; i < arr.Length - 3; i++)
            {
                counter++;
            }
            int y = 0;
            for (int i = 0; i < counter; i++)
            {
                for (int j = y; j < k; j++)
                {
                    numbers.Add(arr[j]);
                }
                y++;
                k++;
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }

};