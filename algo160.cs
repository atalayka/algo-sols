using System;
using System.Collections.Generic;

public class Kata
{
    public static int Number(List<int[]> peopleListInOut)
    {
        // Başlangıçta otobüste kimse yok
        int peopleOnBus = 0;

        // Her durakta otobüse binen ve inenleri say
        foreach (var stop in peopleListInOut)
        {
            int peopleIn = stop[0];
            int peopleOut = stop[1];

            peopleOnBus += peopleIn;
            peopleOnBus -= peopleOut;
        }

        return peopleOnBus;
    }

    public static void Main()
    {
        // Test verisi
        List<int[]> testStops = new List<int[]>
        {
            new int[] { 10, 0 },   // İlk durak: 10 kişi bindi, 0 kişi indi
            new int[] { 3, 5 },    // İkinci durak: 3 kişi bindi, 5 kişi indi
            new int[] { 2, 5 }     // Üçüncü durak: 2 kişi bindi, 5 kişi indi
        };

        // Sonuç
        Console.WriteLine(Number(testStops));  // Otobüste kalan kişi sayısını yazdır
    }
}
