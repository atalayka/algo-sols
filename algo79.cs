using System;
using System.Linq;
namespace HelloWorld
{
    class Program
    {
        public static string GetMiddle(string s)
        {
            return s.Length % 2 == 1 ? Convert.ToString(s[s.Length / 2]): Convert.ToString(s[s.Length / 2 - 1]) + Convert.ToString(s[s.Length / 2]);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetMiddle("helllo"));//should return "ll".
        }
    }
}