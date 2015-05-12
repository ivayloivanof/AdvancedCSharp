using System;
class TextFilter
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine().Split(',');
        string text = Console.ReadLine();

        text = text.Replace(bannedWords[0].Trim(), new string('*', bannedWords[0].Trim().Length));
        text = text.Replace(bannedWords[1].Trim(), new string('*', bannedWords[1].Trim().Length));

        Console.WriteLine(text);
    }
}