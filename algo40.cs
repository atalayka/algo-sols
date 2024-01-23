using System.Linq;

class Solution 
{
  public static int Stray(int[] numbers)
  {
     int counter = 1;
            foreach (var item in numbers)
            {
                if (numbers[counter] == item && numbers.Min() == item)
                {
                    return numbers.Max();
                }
                if (numbers[counter] == item && numbers.Max() == item)
                {
                    return numbers.Min();
                }
            }

            return 0;
  }
}