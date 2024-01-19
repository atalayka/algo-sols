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
        public class Algorithm
        {
            public static string MakeComplement(string dna)
            {
                char[] DnaChar = dna.ToCharArray();
                char[] result = new char[DnaChar.Length];
                for (int i = 0; i < DnaChar.Length; i++)
                {
                    switch (DnaChar[i])
                    {
                        case 'A': result[i] = 'T'; break;
                        case 'T': result[i] = 'A'; break;
                        case 'C': result[i] = 'G'; break;
                        case 'G': result[i] = 'C'; break;
                    }
                }

                return new string(result);
            }
            public static string MakeComplement2(string dna)
            {
                // DNA bazlarının tamamlayıcılarını bir sözlükte depola
                var complements = new Dictionary<char, char>
                    {
                        {'A', 'T'},
                        {'T', 'A'},
                        {'C', 'G'},
                        {'G', 'C'}
                    };

                // LINQ kullanarak DNA dizisinin tamamlayıcısını oluştur
                return new string(dna.Select(c => complements[c]).ToArray());
            }
        }

        static void Main(string[] args)
        {
            string x = "ATTGC";
            Console.WriteLine(Algorithm.MakeComplement(x));
            string y = "ATTGC";
            Console.WriteLine(Algorithm.MakeComplement2(y));
        }
    }

}