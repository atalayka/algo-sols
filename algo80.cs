using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public class Fighter
        {
            public string Name;
            public int Health, DamagePerAttack;
            public Fighter(string name, int health, int damagePerAttack)
            {
                this.Name = name;
                this.Health = health;
                this.DamagePerAttack = damagePerAttack;
            }
        }
        public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
        {
            if (firstAttacker == fighter1.Name)
            {
                while (fighter1.Health > 0 || fighter2.Health > 0)
                {
                    fighter2.Health -= fighter1.DamagePerAttack;
                    fighter1.Health -= fighter2.DamagePerAttack;

                    if (fighter2.Health <= 0) return fighter1.Name;
                }
            }
            else
            {
                while (fighter1.Health > 0 || fighter2.Health > 0)
                {
                    fighter1.Health -= fighter2.DamagePerAttack;
                    fighter2.Health -= fighter1.DamagePerAttack;

                    if (fighter1.Health <= 0) return fighter2.Name;
                }
            }
            return "";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(declareWinner(new Fighter("Harald", 20, 5), new Fighter("Harry", 5, 4), "Harald")); //should return "Harald"
        }

    }
}

