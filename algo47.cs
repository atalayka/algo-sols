using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the sum of subarrays that great equal 7
            int[] arr = { 2, 1, 3, 5, 4, 7, 6 };
            int k = 7;
            List<int> list = [];
            int sum = 0;
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= k)
                {
                    list.Add(arr[i]);
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                }

                else
                {
                    sum += arr[i];
                    list.Add(arr[i]);
                    if (sum >= k)
                    {
                        i -= list.Count - 1;


                        foreach (var item in list)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("");

                        sum = 0;
                        list = [];
                    }
                }
            }
        }
    }
}
