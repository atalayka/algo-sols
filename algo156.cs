namespace HelloWorld;

class Program
{
    public static bool IsIsogram(string str)
    {
        if (string.IsNullOrEmpty(str))
            return true;

        // Küçük  dönüştür
        str = str.ToLower();

        HashSet<char> letters = new HashSet<char>();

        foreach (char c in str)
        {
            if (!letters.Contains(c))
            {
                letters.Add(c);
            }
            else
            {
                return false;
            }
        }

        return true;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(IsIsogram("asdfasdf"));
    }
}