public class Kata
{
  public static double SumArray(double[] array)
  {
    double sum = 0;
  foreach (double number in array)
  {
    sum += number;
  }
  return sum;
  }
}