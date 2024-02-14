using System.Linq;
using System.Collections.Generic;

public class Kata
{
  public static List<int> ReverseList(List<int> list)
  {
    int[] array = list.ToArray();
    List<int> list2 = new List<int>();

    Array.Reverse(array);
    list2 = array.ToList();
    
    return list2;
  }
}