namespace HelloWorld;

class Program
{
    public static bool Hero(int bullets, int dragons)
    {
        return bullets >= dragons * 2 ? true : false;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Hero(10, 5));
    }
}
