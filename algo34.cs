using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        class Algorithm
        {
            public static int[] minMax(int[] lst)
            {
                int x = lst.Min();
                int y = lst.Max();
                int[] result = new int[2];
                result[0] = x;
                result[1] = y;
                return result;
            }
        }
        class MinMax
        {
            public static int[] minMax(int[] lst)
            {
                int x = lst.Min();
                int y = lst.Max();
                return new int[] { x, y };
            }
        }

        static void Main(string[] args)
        {
            int[] dizi = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] sonuc = Algorithm.minMax(dizi);

            // Çözüm 1: Foreach döngüsü ile yazdırma
            foreach (int i in sonuc)
            {
                Console.WriteLine(i);
            }

            // Çözüm 2: ToString() ile yazdırma
            Console.WriteLine(string.Join(", ", sonuc));


            int[] sonuc2 = MinMax.minMax(dizi);
            Console.WriteLine(string.Join(", ", sonuc2));

        }
    }

}