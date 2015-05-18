using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        int length = str.Length;
        int maxLength = 20;
        if (length > maxLength) str = str.Remove(maxLength); else str += new String('*', maxLength - length);
        Console.WriteLine(str);
    }
}