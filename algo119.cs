using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HelloWorld
{

    class Program
    {
        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1 == null || a1.Length == 0 || a2 == null || a2.Length == 0)
            { return -1; }
            List<int> numsa1 = new List<int>();
            List<int> numsa2 = new List<int>();

            foreach (var item in a1)
            {
                numsa1.Add(item.Length);
            }

            foreach (var item in a2)
            {
                numsa2.Add(item.Length);
            }
            int res1 = numsa1.Max() - numsa2.Min();
            int res2 = numsa2.Max() - numsa1.Min();
            return res1 > res2 ? res1 : res2;

        }
        static void Main(string[] args)
        {
            string[] s1 = ["hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"];
            string[] s2 = ["cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"];
            Console.WriteLine(Mxdiflg(s1, s2));
        }
    }
}

