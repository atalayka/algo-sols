using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
  class Program
  {
    public static int Factorial(int n)
    {
      //int result = 1;
      if (n > 12 || n < 0)
      {
        throw new ArgumentOutOfRangeException();
      }
      else
      {
        return Enumerable.Range(1, n).Aggregate(1, (x, y) => x * y);

        /* for (int i = n; i > 1; i--)
         {
             result *= i;
         }
         return result;*/
      }
    }
    static void Main(string[] args)
    {
      Console.WriteLine(Factorial(11));
    }
  }
}

