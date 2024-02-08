using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            List<object> list =[];
            for (int i = 0; i < arr.Length; i += 2)
            {
                list.Add(arr[i]);
            }
            return [.. list];
        }
        static void Main(string[] args)
        {
            string[] arr = ["keepcoding", "remove", "keepcoding", "remove", "keepcoding", "remove", "keepcoding", "remove", "keepcoding", "remove", "keepcoding", "remove", "keepcoding", "remove",];
            Console.WriteLine(string.Join(",",RemoveEveryOther(arr)));
        }
    }
}
