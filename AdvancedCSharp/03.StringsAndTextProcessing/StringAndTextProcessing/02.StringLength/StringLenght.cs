using System;
class StringLenght
{
    static void Main()
    {
        string text = Console.ReadLine();

        if (text.Length < 20)
            Console.WriteLine(text+ new string('*', 20 - text.Length));
        else
            Console.WriteLine(text.Substring(0, 20));
    }
}