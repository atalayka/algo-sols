using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWorld
{

    class Program
    {
        public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            return distanceToPump <= (double)fuelLeft * mpg;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ZeroFuel(25, 2, 1));
        }
    }
}
