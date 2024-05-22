namespace HelloWorld;

class Program
{
    public static string RemoveUrlAnchor(string url)
    {
        if (url.Contains('#'))
        {
            return url.Substring(0, url.IndexOf('#'));
        }
        return url;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(RemoveUrlAnchor("www.codewars.com#about"));
    }
}

