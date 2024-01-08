using System;
namespace HelloWorld
{
    class Program
    {

        public class Algorithm
        {
            public static string seriesSum(int n)
            {
                return (from i in Enumerable.Range(0, n) select 1.0 / (3 * i + 1)).Sum().ToString("0.00");
            }

        }
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////

            Console.WriteLine(Algorithm.seriesSum(5));




            ////////////////////////////////////////////////////
        }

    }
}