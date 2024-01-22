using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        public static int Stray(int[] numbers)
        {
            int counter = 0;
            int counter2 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers.Min())
                {
                    counter++;
                    if (counter > 1)
                    {
                        if (numbers.Max() >= 3)
                        {
                            return numbers.Max();
                        }
                    }
                }
                if (numbers[i] == numbers.Max())
                {
                    counter2++;

                    if (counter2 > 1)
                    {
                        return numbers.Max();
                    }
                    if (numbers.Min() >= 3)
                    {
                        return numbers.Min();
                    }
                }
            }

            return 0;
        }
        static void Main(string[] args)
        {
            int[] x = { 1, 1, 1, 1, 2 };
            Console.WriteLine(Stray(x));
        }
    }
}