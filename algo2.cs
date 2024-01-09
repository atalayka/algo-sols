using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloWorld
{
    class Program
    {

        public class Algorithm
        {
            public static List<int> RemoveSmallest(List<int> numbers)
            {
                List<int> numbersCopy = numbers.ToList();

                if (numbersCopy.Count == 0)
                {
                    return numbersCopy;
                }

                int smallestValue = numbersCopy.Min();
                numbersCopy.Remove(smallestValue);
                return numbersCopy;

            }
        }

        static void Main(string[] args)
        {
            //List<int> testList = new List<int> { };
            List<int> testList = new List<int> { 7, 3, 8, 2, 1, 10, 9, 5, 4, 6 };
            Console.WriteLine(string.Join(",", Algorithm.RemoveSmallest(testList)));
        }
    }
}
