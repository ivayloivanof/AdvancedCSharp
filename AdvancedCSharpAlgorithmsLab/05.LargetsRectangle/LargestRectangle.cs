using System;
using System.Collections.Generic;

class LargestRectangle
{
    static void Main()
    {
        string row = Console.ReadLine();
        List<string> text = new List<string>();

        while (!row.Contains("END"))
        {
            row = Console.ReadLine();
            string rows = row.Substring(1, row.Length-2);
            string[] character = rows.Split(',');
            text.Add(rows);
        }
        Console.WriteLine(string.Join("", text));
    }
}