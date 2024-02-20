using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static bool MakeEqual(string[] words)
        {
            var map = new Dictionary<char, int>();
            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    if (map.ContainsKey(c))
                    {
                        map[c]++;
                    }
                    else
                    {
                        map.Add(c, 1);
                    }
                }
            }
            foreach (var kv in map)
            {
                if (kv.Value % words.Length != 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            string[] x = ["abc", "aabc", "bc"];
            Console.WriteLine(MakeEqual(x));
        }
    }
}

