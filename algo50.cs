using System;

namespace HelloWorld
{
    class Program
    {
        public static string AddBinary(int a, int b)
        {
            int sum = a + b;
            // Convert the sum to binary representation
            return Convert.ToString(sum, 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AddBinary(2, 4));  // Output: 101
        }
    }
}