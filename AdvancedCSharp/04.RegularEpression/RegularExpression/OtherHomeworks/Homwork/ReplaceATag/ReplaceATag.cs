using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class ReplaceATag
{
    static void Main()
    {
        string text = System.IO.File.ReadAllText(@"C:\Users\Asen\Downloads\text.txt");
        string patternOne = @"\<a";
        string patternTwo = @"\<\/a\>";
        string replacerOne = @"[URL";
        string replacerTwo = @"[/URL]";
        Regex regexOne = new Regex(patternOne);
        Regex regexTwo = new Regex(patternTwo);
        string result = regexOne.Replace(text, replacerOne);
        text = result;
        result = regexTwo.Replace(text, replacerTwo);
        text = result;
        Console.WriteLine(text);
    }
}
//Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a>
//with corresponding tags [URL href=…]…[/URL]. Print the result on the console.
