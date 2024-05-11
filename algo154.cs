namespace HelloWorld;

class Program
{
    public static bool IsAnagram(string test, string original)
    {

        test = test.ToLower();
        original = original.ToLower();

        if (test.Length == original.Length)
        {
            foreach (var item in test)
            {
                if (!original.Contains(item.ToString())) return false;
            }
            return true;

        }
        return false;
    }

    static void Main(string[] args)
    {
        Console.WriteLine(IsAnagram("hello", "heLLo"));
    }
}
