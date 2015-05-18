using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static decimal _result = 0;
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in input)
            CalcResult(word.First(), word.Last(), int.Parse(Regex.Match(word, @"\d+").Value));

        Console.WriteLine("{0:F2}", _result);
    }

    static void CalcResult(char first, char last, int num)
    {
        if (Char.IsUpper(first))
            _result += num / (decimal)(first - 'A' + 1);
        else if (Char.IsLower(first))
            _result += num * (decimal)(first - 'a' + 1);

        if (Char.IsUpper(last))
            _result -= (decimal)(last - 'A' + 1);
        else if (Char.IsLower(last))
            _result += (decimal)(last - 'a' + 1);
    }
}