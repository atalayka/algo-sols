using System.Linq;

public static class Kata {
    public static int TotalPoints(string[] games) {
         ////////////////////////////////////////////////////
            int x = 0;

            // Her bir elemanı : itibaren böl
            for (int i = 0; i < games.Length; i++)
            {
                // Skorları ayrı değişkenlere ayır
                int skor1 = int.Parse(games[i].Substring(0, games[i].IndexOf(':')));
                int skor2 = int.Parse(games[i].Substring(games[i].IndexOf(':') + 1));

                // Skoru kontrol et
                if (skor1 > skor2)
                {
                    x += 3;

                }
                else if (skor1 < skor2)
                {
                    x += 0;

                }
                else
                {
                    x += 1;

                }


            }

            return x;

            //////////////////////////////////////////////////
      
      
    }
}