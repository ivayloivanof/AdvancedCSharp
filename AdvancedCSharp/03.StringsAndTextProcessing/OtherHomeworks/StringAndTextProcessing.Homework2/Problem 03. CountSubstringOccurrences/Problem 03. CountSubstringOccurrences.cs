using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        string substr = Console.ReadLine();

        Console.WriteLine(Regex.Matches(str, substr, RegexOptions.IgnoreCase).Count);
    }
}
