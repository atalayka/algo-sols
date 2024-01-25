using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        //triangle 
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return true;
            }
            return false;
        }
        public class Triangle
        {
            public static bool IsTriangle(int a, int b, int c) =>
                a > 0 && b > 0 && c > 0 &&
                a + b > c && a + c > b && b + c > a;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsTriangle(1, 2, 2));
            Console.WriteLine(Triangle.IsTriangle(1, 2, 2));
        }
    }
}