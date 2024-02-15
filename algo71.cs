using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static string[] TowerBuilder(int nFloors)
        {
           string[] tower = new string[nFloors];

        for (int i = 0; i < nFloors; i++)
        {
            int spaces = nFloors - i - 1;
            int asterisks = 2 * i + 1;
            tower[i] = new string(' ', spaces) + new string('*', asterisks) + new string(' ', spaces);
        }
        return tower;
        }
        static void Main(string[] args)
        {
             int nFloors = 6;
        string[] tower = TowerBuilder(nFloors);

        // Print each floor of the tower
        foreach (string floor in tower)
        {
            Console.WriteLine(floor);
        }
        }
    }
}
