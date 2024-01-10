using System;

public static class Paper
{
  public static int Paperwork(int n, int m)
  {
    int BPage = n * m;

    if (n < 0 || m < 0)
    {
      BPage = 0;
    }

    return BPage;

  }
}