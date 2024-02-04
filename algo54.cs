using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            int ArrayLength = BinaryArray.Length - 1;
            int result = 0;
            foreach (int item in BinaryArray)
            {
                result += item * (int)Math.Pow(2, ArrayLength);
                ArrayLength--;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] BinaryArray = [1, 1, 1, 1];
            int ArrayLength = BinaryArray.Length - 1;
            int result = 0;
            foreach (int item in BinaryArray)
            {
                result += item * (int)Math.Pow(2, ArrayLength);
                ArrayLength--;
            }
            Console.WriteLine(result);


        }
    }
}
