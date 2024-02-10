using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        public static int Gimme(double[] inputArray)
        {
            double[] sortedArray = inputArray.ToArray();
            Array.Sort(sortedArray);
            int middleIndex = Array.IndexOf(inputArray, sortedArray[1]);
            return middleIndex;
        }

        static void Main(string[] args)
        {
            double[] array = [-2, 1, 3];
            Console.WriteLine(Gimme(array));
        }
    }
}
