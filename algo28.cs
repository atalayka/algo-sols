using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        public class Algorithm
        {
        }
        public class Funcij
        {
            public static ulong sumin(ulong n)
            {
                ulong takeMin = 0;
                ulong result = 0;

                for (ulong x = 1; x <= n; x++)
                {
                    for (ulong y = n; y >= 1; y--)
                    {
                        takeMin = Math.Min(x, y);
                        result += takeMin;
                    }
                }
                return result;
            }
            public static ulong sumax(ulong n)
            {
                ulong takeMax = 0;
                ulong result = 0;

                for (ulong x = 1; x <= n; x++)
                {
                    for (ulong y = n; y >= 1; y--)
                    {
                        takeMax = Math.Max(x, y);
                        result += takeMax;
                    }
                }
                return result;
            }
            public static ulong sumsum(ulong n)
            {
                ulong takeSum = 0;
                ulong result = 0;

                for (ulong x = 1; x <= n; x++)
                {
                    for (ulong y = n; y >= 1; y--)
                    {
                        takeSum = x + y;
                        result += takeSum;
                    }
                }
                return result;
            }
        }
        static void Main(string[] args)
        {
            ulong result = Funcij.sumin(45);
            Console.WriteLine(result);
            ulong result2 = Funcij.sumax(45);
            Console.WriteLine(result2);
            ulong result3 = Funcij.sumsum(45);
            Console.WriteLine(result3);
        }
    }
}

/*

 n değeri fonksiyona verildi
 n değeri kullanılarak, x ve y değerleri bir kartezyene geçirildi.
 kartezyendeki her bir x ve y değerleri, ilgili metotlarca işlendi
 sonuç dönüldü

 */
