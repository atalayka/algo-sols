using System;
using System.Linq;
using System.Collections.Generic;
using System.Data;


namespace HelloWorld
{
    class Program
    {

        public static List<string> Number(List<string> lines)
        {
            List<string> numberedLines = new List<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                numberedLines.Add((i + 1) + ": " + lines[i]);
            }
            return numberedLines;
        }

        static void Main(string[] args)
        {
            List<string> lines = new List<string> { "Hello", "World", "This", "Is", "Line", "Numbering" };
            List<string> numberedLines = Number(lines);
            foreach (string line in numberedLines)
            {
                Console.WriteLine(line);
            }
        }
    }
}

