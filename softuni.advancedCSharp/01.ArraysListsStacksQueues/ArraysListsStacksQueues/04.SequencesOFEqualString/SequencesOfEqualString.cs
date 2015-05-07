using System;
using System.Collections.Generic;

class SequencesOfEqualString
{
    static void Main()
    {
        List<string> sequence = new List<string>(Console.ReadLine().Split(' '));
        List<string> words = new List<string>();

        for (int i = 0; i < sequence.Count; i++)
        {
            string word = sequence[i];
            for (int j = i+1; j < sequence.Count; j++)
            {
                if (sequence[i].Contains(sequence[j]))
                {
                    word += " "+ sequence[j];
                    sequence.RemoveAt(j);
                }
            }
            words.Add(word);
            sequence.RemoveAt(i);
        }
        Console.WriteLine();
    }
}