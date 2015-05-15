using System;
using System.Linq;
using System.Text.RegularExpressions;

class SerriesOfLetters
{
    static void Main()
    {
        string textForCleaning = Console.ReadLine();
        string pattern = @"([a-z])\1*";
        Regex regex = new Regex(pattern);
        MatchCollection matches = Regex.Matches(textForCleaning, pattern);

        for (int i = 0; i < matches.Count; i++)
        {
            string tempPattern = matches[i].ToString();
            string replace = tempPattern.First().ToString();
            Regex tempRegex = new Regex(tempPattern);
            textForCleaning = tempRegex.Replace(textForCleaning, replace);
        }

        Console.WriteLine(textForCleaning);
    }
}