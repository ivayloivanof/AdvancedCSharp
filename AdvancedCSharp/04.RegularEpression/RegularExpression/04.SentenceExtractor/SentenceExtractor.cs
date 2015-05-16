using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();
        string[] lines = Regex.Split(text, @"(?<=[.!?])\s+");
        foreach (string line in lines)
        {
            MatchCollection match = Regex.Matches(line, @"\s"+pattern+ @"\s+([\w]+)");
            if (match.Count != 0)
                Console.WriteLine(line.Trim());
        }
        Console.WriteLine();
    }
}