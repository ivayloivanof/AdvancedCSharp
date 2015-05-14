using System;
using System.Linq;
using System.Collections.Generic;
class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        SortedSet<char> letters = new SortedSet<char>();
        foreach (var symbol in input)
        {
            letters.Add(symbol);
        }
        foreach (var letter in letters) 
        {
            int count = 0;
            int index = -1;
            int next = 0;
            while (index < input.LastIndexOf(letter))
	        {
	            index = input.IndexOf(letter, next); 
                count++; 
                next = index + 1; 
	        }
            Console.WriteLine("{0}: {1} time/s", letter, count);
        }
    }
}

