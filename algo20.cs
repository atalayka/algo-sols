using System;
using System.Collections.Generic;

namespace Solution
{
  class Digitizer
  {
    public static long[] Digitize(long n)
    {
       string numberStr = n.ToString();
            long[] result = new long[numberStr.Length];
            for (int i = 0; i < numberStr.Length; i++)
            {
                result[i] = long.Parse(numberStr[i].ToString());
            }
            Array.Reverse(result);
            return result;
    }
  }
}