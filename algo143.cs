using System.Collections.Generic;

namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
            public List<string> Wave(string str)
            {
                var result = new List<string>();

                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsWhiteSpace(str[i]))
                        continue;

                    var word = str.ToCharArray();
                    word[i] = char.ToUpper(word[i]);
                    result.Add(new string(word));
                }

                return result;
            }
        }
    }
}