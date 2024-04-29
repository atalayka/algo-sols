using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;


namespace HelloWorld
{
    class Program
    {
        //thread pool problem.
        public static long QueueTime(int[] customers, int n)
        {
            if (n == 1)
            {
                return customers.Sum();
            }

            int[] tills = new int[n];

            // Initialize tills with the first n customers
            for (int i = 0; i < n; i++)
            {
                tills[i] = customers[i];
            }

            // Iterate through the remaining customers
            for (int i = n; i < customers.Length; i++)
            {
                int minTillIndex = Array.IndexOf(tills, tills.Min()); // Find the till with the minimum time
                tills[minTillIndex] += customers[i]; // Add the current customer's time to the minimum till
            }

            // Return the maximum time taken by any till
            return tills.Max();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(QueueTime(new int[] { 2, 3, 10 }, 2)); //should return 12
            Console.WriteLine(QueueTime(new int[] { 10, 2, 3, 3 }, 2)); //should return 10

        }
    }
}

