using System;
using System.Text.RegularExpressions;

class ValidUsername
{
    static void Main()
    {
        string usernames = Console.ReadLine();
        string pattern = @"\b[a-zA-Z]\w{2,24}\b";
        Regex users = new Regex(pattern);
        MatchCollection matches = users.Matches(usernames);

        int firstUsename = 0;
        int secondUsername = 1;
        int bestSum = int.MinValue;
        int sum = 0;
        for (int i = 0; i < matches.Count - 1; i++)
        {
            sum = matches[i].Length + matches[i + 1].Length;
            if (sum > bestSum)
            {
                bestSum = sum;
                firstUsename = i;
                secondUsername = i + 1;
            }
        }
        Console.WriteLine(matches[firstUsename]);
        Console.WriteLine(matches[secondUsername]);

    }
}
