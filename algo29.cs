using System;
using System.Collections.Generic;
using System.Linq; 

public class GpsSpeed {
    
    public static int Gps(int s, double[] x) {
                  if (x.Length <= 1)
            {
                return 0; // Eğer dizi 1 veya daha az elemana sahipse, maksimum hız 0'dır.
            }

            List<double> speeds = new List<double>(); // Hızları depolamak için bir liste oluşturuyoruz.

            for (int i = 1; i < x.Length; i++) // Dizinin ilk elemanından başlayarak döngüye giriyoruz.
            {
                double distance = x[i] - x[i - 1]; // İki ardışık konum arasındaki mesafeyi hesaplıyoruz.
                double speed = 3600 * distance / s; // Saatlik hızı hesaplıyoruz.
                speeds.Add(speed); // Hızı listeye ekliyoruz.
            }

            return (int)Math.Floor(speeds.Max()); // Listedeki en yüksek hızın tam sayı kısmını döndürüyoruz.
    
    }
}