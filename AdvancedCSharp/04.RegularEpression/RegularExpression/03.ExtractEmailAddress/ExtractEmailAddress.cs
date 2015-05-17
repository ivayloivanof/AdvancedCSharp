using System;
using System.Text.RegularExpressions;

class ExtractEmailAddress
{
    static void Main()
    {
        string text = Console.ReadLine();

        string pattern = @"\w+([-._]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
        Regex regex = new Regex(pattern);
        MatchCollection email = regex.Matches(text);
        foreach (Match match in email)
        {
            Console.WriteLine(match);
        }

    }
}