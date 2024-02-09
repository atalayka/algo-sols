using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public class Solution
        {
            public static int MaxLengthBetweenEqualCharacters(string s)
            {
                var map = new Dictionary<char, int>();
                var max = -1;

                for (int i = 0; i < s.Length; i++)
                {
                    if (map.ContainsKey(s[i]))
                    {
                        max = Math.Max(max, i - map[s[i]] - 1);
                    }
                    else
                    {
                        map.Add(s[i], i);
                    }
                }
                return max;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.MaxLengthBetweenEqualCharacters("abasdasdasdasdca"));
        }
    }
}
