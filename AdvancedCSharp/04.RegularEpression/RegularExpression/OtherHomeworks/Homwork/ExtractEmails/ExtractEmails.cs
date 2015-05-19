using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class ExtractEmails
{
    static void Main()
    {
        string text = "Just send email to s.miller@mit.edu and j.hopking@york.ac.uk for more information.";
        string patternTwo = @"[a-zA-Z]{1,5}?(?=\.)\.[\w\-]{4,12}@[a-z]{2,}\.[a-z]{1,4}";
        Regex regexTwo = new Regex(patternTwo);
        MatchCollection matchesTwo = regexTwo.Matches(text);
        foreach (var item in matchesTwo)
        {
            Console.WriteLine(item);
        }
    }
}
//Write a program to extract all email addresses from a given text. The text comes at the only
//input line. Print the emails on the console, each at a separate line. Emails are considered to
//be in format <user>@<host>,

