using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    
            int[] numbers = new int[n];
            int Counter = 0;

            for (int i = n; i > 0; i--)
            {
                numbers[Counter] = i;
                Counter++;
            }

            return numbers;
  }
}