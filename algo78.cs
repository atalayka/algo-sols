using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
public class Kata
{
    public static string[] SortByLength(string[] array)
    {
        List<string> strings = new List<string>();
        var map = new Dictionary<int, string>();

        foreach (string str in array)
        {
            map.Add(str.Length, str);
        }

        for (int i = 0; i < 50; i++)
        {
            if (map.ContainsKey(i))
            {
                strings.Add(map[i]);
            }
        }

        return strings.ToArray();
        //return array.OrderBy(x => x.Length).ToArray();

    }
}