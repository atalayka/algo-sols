using System;
using System.Linq;
namespace HelloWorld
{
    class Program
    {
        public static bool XO(string input)
        {
            int CounterX = 0;
            int CounterO = 0;

            foreach (var item in input)
            {
                switch (item)
                {
                    case 'x': CounterX++; break;
                    case 'X': CounterX++; break;
                    case 'O': CounterO++; break;
                    case 'o': CounterO++; break;
                }
            }
            return CounterX == CounterO;
        }
        public static bool XO1(string input)
        {
            int xCount = input.Count(c => char.ToLowerInvariant(c) == 'x');
            int oCount = input.Count(c => char.ToLowerInvariant(c) == 'o');
            return xCount == oCount;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(XO("xoxoxoxox"));
            Console.WriteLine(XO1("xoxoxoxox"));
        }
    }
}