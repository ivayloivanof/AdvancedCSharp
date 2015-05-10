using System;
class CollectTheCoins
{
    static void Main()
    {
        char[][] collection = new char[5][];
        for (int i = 0; i < 5; i++)
        {
            string row = Console.ReadLine();
            collection[i] = new char [row.Length];
            for (int j = 0; j < row.Length; j++)
            {
                collection[i][j] = row[j];
            }
        }
        WalkIntoAnArray(collection);
        Console.WriteLine();
    }

    private static void WalkIntoAnArray(char[][] collection)
    {
        int wall = 0;
        int coins = 0;
        for (int i = 0; i < collection.Length; i++)
        {
            for (int j = 0; j < collection[i].Length; j++)
            {
                char field = collection[i][j];
                if (field == '$')
                {
                    coins++;
                }

                if (field == 'V')
                {
                    i++;
                    if (i == collection.Length)
                    {
                        wall++;
                        i--;
                    }
                }
                else if (field == '>')
                {
                    j++;
                    if (j == collection[i].Length)
                    {
                        wall++;
                        j--;
                    }
                }
                else if (field == '<')
                {
                    j--;
                    if (j < 0)
                    {
                        wall++;
                        j++;
                    }
                }
                else if (field == '^')
                {
                    i--;
                    if (i < 0)
                    {
                        wall++;
                        i++;
                    }
                }
            }
        }
        Console.WriteLine(coins);
        Console.WriteLine(wall);
    }
}