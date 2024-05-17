namespace HelloWorld;

class Program
{
    public static int GetSum(int a, int b)
    {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);

        int sum = 0;
        for (int i = min; i <= max; i++)
        {
            sum += i;
        }
        //int sum = (max - min + 1) * (min + max) / 2;
        return sum;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(GetSum(0, 5));
    }
}