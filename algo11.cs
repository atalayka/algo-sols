using System;

public static class Kata
{
  public static string ReverseWords(string str)
  {
            string str1 = "";
            string str2 = "";
            int sayac = 0;
            string[] SplittedString = str.Split(" ");
            foreach (var item in SplittedString)
            {

                str1 = item.ToString();

                if (sayac > 0) { str1 += " "; }
                sayac++;

                for (int i = str1.Length - 1; i >= 0; i--)
                {
                    str2 += str1[i];
                }

            }

            return str2;

  }
}