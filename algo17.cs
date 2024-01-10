public class Kata
{
    public static bool Feast(string beast, string dish)
    {
        char[] chars = beast.ToCharArray();
        char[] char1 = dish.ToCharArray();

        // Check if the first and last letters of the two strings are the same.
        return chars[0] == char1[0] && chars[^1] == char1[^1];
    }
}