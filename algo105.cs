using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //number of laser beams leetcode
        public static int NumberOfBeams(string[] bank)
        {
            var prevCount = OneCounts(bank[0]);
            var result = 0;

            for (var i = 1; i < bank.Length; i++)
            {
                var currCount = OneCounts(bank[i]);
                if (currCount != 0)
                {
                    result += prevCount * currCount;
                    prevCount = currCount;
                }
            }


            return result;
        }
        private static int OneCounts(string s)
        {
            var count = 0;
            foreach (var item in s)
            {
                if (item == '1')
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NumberOfBeams(["01100100", "00100000", "01101111", "01101110"]));
        }
    }
}

