using System;

public static class Kata
{
  public static int CountSheeps(bool[] sheeps)
  {
    int sheepCount = 0;
    foreach (var x in sheeps)
    {
      if (x == true)
      {
        sheepCount++;
      }
    }
    return sheepCount;
  }
}