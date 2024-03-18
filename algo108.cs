using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int SumOfMinimums(int[,] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                int min = numbers[i, 0];
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] < min)
                    {
                        min = numbers[i, j];
                    }
                }
                sum += min;
            }

           /* List<int> x = new List<int>();
            List<int> nums = [];
            int min = 0;
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    nums.Add(numbers[i, j]);
                }
                min += nums.Min();
                nums.Clear();
            }*/
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfMinimums(new int[3, 5] { { 7, 9, 8, 6, 2 }, { 6, 3, 5, 4, 3 }, { 5, 8, 7, 4, 5 } }));
        }
    }
}

