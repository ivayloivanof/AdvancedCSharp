using System;
using System.Linq;

class CountSubstringOccurrences
{
    static void Main()
    {
        string text = Console.ReadLine();
        string pattern = Console.ReadLine();

        int count = text.Select((c, i) => text.Substring(i)).
                            Count(x => x.StartsWith(pattern, StringComparison.CurrentCultureIgnoreCase));
        Console.WriteLine(count);
    }
}