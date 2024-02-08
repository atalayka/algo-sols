using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //Value class
        public class RummyTiles
        {
            public string[] Tiles =
                 [
                "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "R10", "R11", "R12", "R13",
                "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12", "B13",
                "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10", "S11", "S12", "S13",
                "Y1", "Y2", "Y3", "Y4", "Y5", "Y6", "Y7", "Y8", "Y9", "Y10", "Y11", "Y12", "Y13",
                "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "R10", "R11", "R12", "R13",
                "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "B11", "B12", "B13",
                "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "S10", "S11", "S12", "S13",
                "Y1", "Y2", "Y3", "Y4", "Y5", "Y6", "Y7", "Y8", "Y9", "Y10", "Y11", "Y12",  "Y13",
                "FJ", "FJ"
                ];
        }

        //Operation Class
        public class GetTilesRandomly
        {
            int RandomIndex = 0;    
            public List<string> RummyHand = [];
            public Random random = new Random();
            RummyTiles rummyTiles = new();
            public List<string> RandomHand()
            {
                for (int i = 0; i < 15; i++)
                {
                    RandomIndex = random.Next(rummyTiles.Tiles.Length);
                    RummyHand.Add(rummyTiles.Tiles[RandomIndex]);
                }
                return RummyHand;
            }

            public List<string> SameColorLineerNumber()
            {
                List<string> unsorted = RandomHand();
                List<string> ScLnSorted = unsorted.OrderBy(x => x).ToList();
                return ScLnSorted;
            }
        }
        static void Main(string[] args)
        {
            GetTilesRandomly getTilesRandomly = new();
            List<string> x = getTilesRandomly.SameColorLineerNumber();
            foreach (var item in x)
            {
                Console.WriteLine(item);
            }
        }
    }
}
