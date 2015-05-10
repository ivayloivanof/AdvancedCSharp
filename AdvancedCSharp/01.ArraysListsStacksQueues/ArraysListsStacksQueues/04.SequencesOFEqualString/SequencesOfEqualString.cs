using System;

class SequencesOfEqualString
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split();

        for (int i = 0; i < words.Length - 1; i++)
        {
            Console.Write(words[i] + " ");
            if (!words[i].Equals(words[i + 1]))
            {
                Console.WriteLine();
            }
        }
        Console.Write(words[words.Length - 1]);
        Console.WriteLine();
    }
}