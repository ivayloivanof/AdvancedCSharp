using System;
class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int maxPad = 20;

        if (input.Length <= maxPad)
        {
            Console.WriteLine(input.PadRight(maxPad, '*'));
        }

    }
}

