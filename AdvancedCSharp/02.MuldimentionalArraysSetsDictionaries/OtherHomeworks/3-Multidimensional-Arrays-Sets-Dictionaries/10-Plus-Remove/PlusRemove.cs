using System;
using System.Collections.Generic;
using System.Linq;
class PlusRemove
{
    static void Main()
    {
        List<string> lines = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            lines.Add(input);
        }
        char[][] symbols = new char[lines.Count][];
        char[][] copySymbols = new char[lines.Count][];
        for (int i = 0; i < lines.Count; i++)
        {
            symbols[i] = lines[i].ToArray();
            copySymbols[i] = lines[i].ToArray();
        }
        for (int row = 1; row < symbols.Length - 1; row++)
        {
            for (int col = 1; col < symbols[row].Length - 1; col++)
            {
                if (!(col >= symbols[row - 1].Length || col >= symbols[row + 1].Length))
                {

                    int caseLetters = 0;
                    if (symbols[row][col] >= 'a' && symbols[row][col] <= 'z')
                    {
                        caseLetters = symbols[row][col] - 32;
                    }
                    else if (symbols[row][col] >= 'A' && symbols[row][col] <= 'Z')
                    {
                        caseLetters = symbols[row][col] + 32;
                    }
                    if (new[] { symbols[row][col], symbols[row + 1][col], symbols[row - 1][col], symbols[row][col - 1], symbols[row][col + 1] }.All(x => x == symbols[row][col] || x == caseLetters))
                    {
                        copySymbols[row][col] = copySymbols[row + 1][col] = copySymbols[row - 1][col] = copySymbols[row][col - 1] = copySymbols[row][col + 1] = ' ';
                    }
                }
            }
        }
        Console.WriteLine();
        for (int row = 0; row < copySymbols.Length; row++)
        {
            for (int col = 0; col < copySymbols[row].Length; col++)
            {
                if (copySymbols[row][col] != ' ')
                {
                    Console.Write(copySymbols[row][col]);
                }
            }
            Console.WriteLine();
        }
    }
}

