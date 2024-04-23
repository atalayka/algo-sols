using System;
using System.Linq;
using System.Collections.Generic;


namespace HelloWorld
{
    class Program
    {
        public static string[] inArray(string[] array1, string[] array2)
        {
            HashSet<string> result = new HashSet<string>();
            foreach (var word1 in array1)
            {
                foreach (var word2 in array2)
                {
                    if (word2.Contains(word1))
                    {
                        result.Add(word1);
                        break; // Diğer kelimeye geç
                    }
                }
            }
            return result.OrderBy(w => w).ToArray();
        }

        static void Main(string[] args)
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };

            string[] result = inArray(a1, a2);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}