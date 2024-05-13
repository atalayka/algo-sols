namespace HelloWorld;

class Program
{
    public static string ChromosomeCheck(string sperm)
    {
        return sperm == "XY" ? "Congratulations! You're going to have a son." : "Congratulations! You're going to have a daughter.";
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(ChromosomeCheck("XY"));
    }
}