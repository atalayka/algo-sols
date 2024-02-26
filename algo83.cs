using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace HelloWorld
{
    class Program
    {
        public string Rps(string p1, string p2)
        {
            if (p1 == p2)
            {
                return "Draw";
            }

            if (
                (p1 == "rock" && p2 == "scissors") ||
                (p1 == "paper" && p2 == "rock") ||
                (p1 == "scissors" && p2 == "paper")
            )
            {
                return "Player 1 wins";
            }

            if (
                (p2 == "rock" && p1 == "scissors") ||
                (p2 == "paper" && p1 == "rock") ||
                (p2 == "scissors" && p1 == "paper")
            )
            {
                return "Player 2 wins";
            }

            return "Error";
        }
        static void Main(string[] args)
        {
        }
    }
}

