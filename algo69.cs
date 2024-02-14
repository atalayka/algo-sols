using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            int nLength = numbers.Length;
            for (int i = 0; i < nLength; i++)
            {
                for (int j = 1; j < nLength; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return new int[0];
        }
        static void Main(string[] args)
        {
            int[] numbers = [2, 3, 4];
            int target = 6;
            Console.WriteLine(TwoSum(numbers, target));
        }
    }
}
