class Kata
{
  public static int[] RowWeights(int[] a)
  {
    //return new int[] { a.Where((x, i) => i % 2 == 0).Sum(), a.Where((x, i) => i % 2 != 0).Sum() };

    int[] result = new int[2];
    int counter = 0;
    foreach (var item in a)
    {
      if (counter % 2 == 0)
      {
        result[0] += item;
      }
      else
      {
        result[1] += item;
      }
      counter++;
    }
    return result;
  }
}