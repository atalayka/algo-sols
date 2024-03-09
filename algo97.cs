using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //each row will hold only distinct numbers
        //number of rows, should  minimum as possible

        public static IList<IList<int>> FindMatrix(int[] nums)
        {
            var map = new Dictionary<int, int>();
            List<IList<int>> result = new List<IList<int>>();

            foreach (var num in nums)
            {
                if (map.ContainsKey(num))
                {
                    if (result.Count == map[num])
                    {
                        result.Add(new List<int>() { num });
                    }
                    else
                    {
                        result[map[num]].Add(num);
                    }
                    map[num]++;
                }
                else
                {
                    map.Add(num, 1);
                    if (result.Count == 0)
                    {
                        result.Add(new List<int>() { num });
                    }
                    else
                    {
                        result[0].Add(num);
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] arr = [1,3,4,1,2,3,1];
            FindMatrix(arr);
        }
    }
}

