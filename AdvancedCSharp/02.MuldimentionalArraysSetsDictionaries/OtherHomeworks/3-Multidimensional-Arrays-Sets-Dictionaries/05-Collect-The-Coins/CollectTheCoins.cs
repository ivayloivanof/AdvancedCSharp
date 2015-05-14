using System;
class CollectTheCoins
{
    static void Main()
    {
        char[][] board = new char[4][];
        for (int i = 0; i < 4; i++)
        {
            var input = Console.ReadLine().ToCharArray();
            board[i] = input;
        }
        int row = 0;
        int col = 0;
        int coins = 0;
        int walls = 0;
        var moves = Console.ReadLine().ToCharArray();
        foreach (var move in moves)
        {
            if (board[row][col] == '$')
            {
                coins++;
            }
            switch (move)
            {
                case '>':
                    if (col == board[row].Length - 1)
                    {
                        walls++;
                    }
                    else
                    {
                        col++;
                    }
                    break;
                case '<':
                    if (col == 0)
                    {
                        walls++;
                    }
                    else
                    {
                        col--;
                    }
                    break;
                case '^':
                    if (row == 0 || board[row - 1].Length - 1 < col)
                    {
                        walls++;
                    }
                    else
                    {
                        row--;
                    }
                    break;
                case 'v':
                case 'V':
                    if (row == 3 || board[row + 1].Length - 1 < col)
                    {
                        walls++;
                    }
                    else
                    {
                        row++;
                    }
                    break;
            }
        }
        Console.WriteLine("Coins collected: {0}", coins);
        Console.WriteLine("Walls hit: {0}", walls);
    }
}

