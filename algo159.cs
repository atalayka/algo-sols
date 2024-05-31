namespace HelloWorld;

class Program
{
    public static bool Solution(string str, string ending)
    {
        if (str.Length < ending.Length) return false;
        return str.EndsWith(ending);
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(Solution("abc", "bc"));
    }
}

