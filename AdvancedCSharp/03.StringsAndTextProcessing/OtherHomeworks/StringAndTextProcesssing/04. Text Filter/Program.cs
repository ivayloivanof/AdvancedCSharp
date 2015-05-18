using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string[] badWords = Console.ReadLine().Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        string input = Console.ReadLine();
        Console.WriteLine(Filter(input, badWords));
    }

    public static string Filter(string input, string[] badWords)
    {
        var re = new Regex(
            @"\b("
            + string.Join("|", badWords.Select(word =>
                string.Join(@"\s*", word.ToCharArray())))
            + @")\b", RegexOptions.IgnoreCase);
        return re.Replace(input, match =>
        {
            return new string('*', match.Length);
        });
    }
}

