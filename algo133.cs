using System;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

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
                    if (fighter2.Health <= 0)
                    {
                        return fighter1.Name;
                    }
                    fighter1.Health -= fighter2.DamagePerAttack;
                    if (fighter1.Health <= 0)
                    {
                        return fighter2.Name;
                    }
                }
            }
            else if (firstAttacker == fighter2.Name)
            {
                while (fighter1.Health > 0 || fighter2.Health > 0)
                {
                    fighter1.Health -= fighter2.DamagePerAttack;
                    if (fighter1.Health <= 0)
                    {
                        return fighter2.Name;
                    }
                    fighter2.Health -= fighter1.DamagePerAttack;
                    if (fighter2.Health <= 0)
                    {
                        return fighter1.Name;
                    }
                }
            }
            return null;

            /*
            public class Kata
{
    public static string declareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
    {
        var (attacker, defender) = firstAttacker == fighter1.Name
              ? (fighter1, fighter2)
              : (fighter2, fighter1);

        while (true)
        {
            defender.Health -= attacker.DamagePerAttack;
            if (defender.Health <= 0)
            {
                return attacker.Name;
            }
            (attacker, defender) = (defender, attacker);

        }
    }
}
*/
        }
        static void Main(string[] args)
        {
            Console.WriteLine(declareWinner(new Fighter("Lew", 10, 2), new Fighter("Harry", 5, 4), "Lew")); // "Lew"
        }
    }
}