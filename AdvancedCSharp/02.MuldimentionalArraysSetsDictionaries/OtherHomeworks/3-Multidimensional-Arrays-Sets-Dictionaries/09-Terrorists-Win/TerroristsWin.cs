using System;
class TerroristsWin
{
    static void Main()
    {
        string input = Console.ReadLine();
        for (int k = 0; k < input.Length; k++)
        {
            int firstBombIndex = input.IndexOf('|', k);
            int secondBombIndex = input.IndexOf('|', firstBombIndex + 1);
            string bomb = input.Substring(firstBombIndex + 1, secondBombIndex - firstBombIndex - 1);
            int bombPower = 0;
            foreach (var symbol in bomb)
            {
                 bombPower += symbol;
            }
            bombPower = bombPower % 10;
            char[] afterBomb = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                afterBomb[i] = input[i];
            }
            for (int i = firstBombIndex - bombPower; i <= secondBombIndex + bombPower; i++)
            {
               afterBomb[i] = '.';
            }
            input = string.Join("", afterBomb);
            k += secondBombIndex;
           }
        Console.WriteLine(input);
    }
}

