using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public class ListFilterer
        {
            public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
            {
                return listOfItems.OfType<int>();
            }
        }

        static void Main(string[] args)
        {
            var list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            IEnumerable<int> ints = ListFilterer.GetIntegersFromList(list);

            Console.WriteLine(string.Join(", ", ints)); // Print integers separated by commasvar list = new List<object>() { 1, 2, "aasf", "1", "123", 123 };
            ListFilterer.GetIntegersFromList(list);

            Console.WriteLine(ints);
        }
    }
}
