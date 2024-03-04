using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static int[] Capitals(string word)
        {
            List<int> uppercaseList = new List<int>();
            int indexCounter = 0;
            foreach (char character in word)
            {
                if (char.IsUpper(character))
                {
                    uppercaseList.Add(indexCounter);
                }
                indexCounter++;
            }
            return uppercaseList.ToArray();
            //return word.Select((c, i) => char.IsUpper(c) ? i : -1).Where(i => i != -1).ToArray();
        }
        static void Main(string[] args)
        {
            Capitals("CoDeWaRs");
        }
    }
}

