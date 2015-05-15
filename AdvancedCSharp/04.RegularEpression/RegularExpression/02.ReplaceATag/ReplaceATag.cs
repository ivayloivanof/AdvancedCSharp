using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ReplaceATag
{
    static void Main()
    {
        List<string> exit = new List<string>(); 
        for (int i = 0; i < 5; i++)
        {
            string text = Console.ReadLine();
            
            if (text.Contains("\""))
            {
                text = Regex.Replace(text, "\"", "");
                exit.Add(text);
            }
            else if (!text.Contains("<a href="))
                exit.Add(text);
            else
            {
                text = Regex.Replace(text, @"(<a )", "[URL ");
                text = Regex.Replace(text, @"(<\/a>)", "[/URL]");
                exit.Add(text);
            }
        }
        foreach (string s in exit)
        {
            Console.WriteLine(s);
        }
    }
}