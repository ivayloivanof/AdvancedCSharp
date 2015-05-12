using System;
class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();
        foreach (char c in text)
        {
            Console.Write("\\u" + ((int)c).ToString("X4"));
        }
        Console.WriteLine();
    }
}