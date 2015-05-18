using System;
using System.Linq;
using System.Text.RegularExpressions;

class TextFilter
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split(new[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        string input = Console.ReadLine();
        Console.WriteLine(Filter(input, words));
    }

    public static string Filter(string input, string[] words)
    {
        var re = new Regex(
            @"\b("
            + string.Join("|", words.Select(word =>
                string.Join(@"\s*", word.ToCharArray())))
            + @")\b", RegexOptions.IgnoreCase);
        return re.Replace(input, match =>
        {
            return new string('*', match.Length);
        });
    }
}