using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            List<string> friends = new List<string>();
            foreach (string name in names)
            {
                if (name.Length == 4)
                {
                    friends.Add(name);
                }
            }
            return friends;
            //return names.Where(name => name.Length == 4);

        }
        static void Main(string[] args)
        {
            string[] inputNames = { "Ryan", "Kieran", "Jason", "Yous" };
            IEnumerable<string> friends = FriendOrFoe(inputNames);

            Console.WriteLine("Friends: [" + string.Join(", ", friends) + "]");
        }
    }
}

