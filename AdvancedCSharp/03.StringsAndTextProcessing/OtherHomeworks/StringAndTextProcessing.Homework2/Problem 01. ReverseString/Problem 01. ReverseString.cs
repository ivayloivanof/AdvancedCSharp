using System;
using System.Linq;

class Program
{
    static void Main()
    {
        char[] text = Console.ReadLine().ToCharArray();
        Array.Reverse(text);
        Console.WriteLine(text);
    }
}
