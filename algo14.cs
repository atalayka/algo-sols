public class Kata
{
    public static int FindSmallestInt(int[] args)
    {
        int smallest = args[0];
        foreach (int number in args)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }
        return smallest;
    }
}