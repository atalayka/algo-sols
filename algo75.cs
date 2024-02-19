using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int SequenceSum(int start, int end, int step)
        {
            if (start <= end)
            {
                int Sum = 0;
                for (int i = start; i <= end; i += step)
                {
                    Console.WriteLine(i);
                    Sum += i;
                }
                return Sum;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SequenceSum(1, 15, 3));//should return 35
        }
    }
}

