using System;
using System.Collections.Generic;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        HashSet<char> seenChars = new HashSet<char>();
        foreach (char c in str.ToLower())
        {
            if (!char.IsLetter(c)) continue;
            if (seenChars.Contains(c)) return false;
            seenChars.Add(c);
        }
        return true;
    }
}

using System;
using System.Linq;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        return str.ToLower().Distinct().Count() == str.Length;
    }
}

using System;

public class Kata
{
    public static bool IsIsogram(string str)
    {
        string str2 = str.ToLower();
        for (int i = 0; i < str2.Length; i++)
        {
            for (int j = i + 1; j < str2.Length; j++)
            {
                if (str2[i] == str2[j])
                {
                    return false;
                }
            }
        }

        return true;
    }
}