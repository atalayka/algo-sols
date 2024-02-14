using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
       public static List<int> twoSum(List<int> nums, int target)
        {
            int LCount = nums.Count();
            for (int i = 0; i < LCount; i++)
            {
                for (int j = 1; j < LCount; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        Console.WriteLine(i);
                        Console.WriteLine(j);
                        return new List<int>() { i, j };
                    }
                }
            }
            return new List<int>() { };
        }
        static void Main(string[] args)
        {
            List<int> nums = [2, 3, 4];
            int target = 5;
            Console.WriteLine(twoSum(nums, target));    
        }
    }
}
