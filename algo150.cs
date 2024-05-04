using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;


namespace HelloWorld
{
    class Program
    {
        public static int[] GetEvenNumbers(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).ToArray();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetEvenNumbers(new int[] { 2, 4, 5 }));
        }
    }
}
