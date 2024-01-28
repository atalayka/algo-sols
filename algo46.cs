using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = [2, 1, 3, 5, 4, 7, 6];
            int k = 3;
            int currentSum = 0;

            int counter = 1;
            for (int i = 0; i < arr.Length - k; i++)
            {
                counter++;
            }

            int[] arr2 = [counter];
            List<int> sum = [];


            int counter2 = 0;
            for (int i = 0; i < counter; i++)
            {
                for (int j = counter2; j < k; j++)
                {
                    Console.Write(arr[j] + " ");
                    currentSum += arr[j];
                }
                sum.Add(currentSum);
                currentSum = 0;
                counter2++;
                k++;
                Console.WriteLine("");
            }
            foreach (var item in sum)
            {
                Console.Write(item + " ");
            }

        }
    }

};