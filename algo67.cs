using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {

        public static List<int> PipeFix(List<int> numbers)
        {
            int LastNumber = numbers.Last();
            int FirstNumber = numbers.First();
            numbers.Clear();
            for (int i = FirstNumber; i <= LastNumber; i++)
            {
                numbers.Add(i);
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            List<int> x = [1, 3, 4, 8, 17];
            Console.WriteLine(PipeFix(x));
        }
    }
}
