using System;
class ReverseString
{
    static void Main()
    {
        string text = Console.ReadLine();
        for (int i = text.Length; i > 0; i--)
        {
            Console.Write(text[i-1]);
        }
        Console.WriteLine();
    }
}
