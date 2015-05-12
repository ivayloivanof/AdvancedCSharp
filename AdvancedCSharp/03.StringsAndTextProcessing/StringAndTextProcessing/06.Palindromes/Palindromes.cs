using System;
using System.Linq;
using System.Text.RegularExpressions;
class Palindromes
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        var result = Regex.Matches(text, @"\w+").Cast<Match>().Select(m => m.Value)
                    .Where(w => String.Join("", w.Reverse()) == w).ToList();
        Console.WriteLine(string.Join(", ", result));
    }
}