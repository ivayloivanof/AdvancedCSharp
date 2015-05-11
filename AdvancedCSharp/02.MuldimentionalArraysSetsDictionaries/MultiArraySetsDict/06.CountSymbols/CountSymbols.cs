using System;
using System.Collections.Generic;

class CountSymbols
{
    static void Main()
    {
        string text = Console.ReadLine();

        SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();
        foreach (char symbol in text)
        {
            if (dictionary.ContainsKey(symbol))
                dictionary[symbol]++;
            else
                dictionary.Add(symbol, 1);
        }

        foreach (KeyValuePair<char, int> dict in dictionary)
        {
            Console.WriteLine("{0}: {1} time/s", dict.Key, dict.Value);
        }
    }
}