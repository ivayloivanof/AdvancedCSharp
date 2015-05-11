using System;
class CollectTheCoins
{
    static void Main()
    {
        string[] board = new string[4];
        for (int row = 0; row < board.GetLength(0); row++)
        {
            board[row] = Console.ReadLine();

        }
        WalkIntoAnArray(board);
    }

    private static void WalkIntoAnArray(string[] board)
    {
        int currentRow = 0;
        int currentCol = 0;
        int coinsCount = 0;
        int wallHitsCount = 0;
        string movementCommands = Console.ReadLine();
        foreach (char currentDirection in movementCommands)
        {
            if (currentDirection == 'V')
            {
                currentRow++;
                if (currentRow >= board.GetLength(0))
                {
                    currentRow--;
                    wallHitsCount++;
                    continue;
                }
                else if (currentCol >= board[currentRow].Length)
                {
                    currentRow--;
                    wallHitsCount++;
                    continue;
                }
            }
            else if (currentDirection == '>')
            {
                currentCol++;
                if (currentCol >= board[currentRow].Length)
                {
                    currentCol--;
                    wallHitsCount++;
                    continue;
                }
            }
            else if (currentDirection == '<')
            {
                currentCol--;
                if (currentCol < 0)
                {
                    currentCol++;
                    wallHitsCount++;
                    continue;
                }
            }
            else if (currentDirection == '^')
            {
                currentRow--;
                if (currentRow < 0)
                {
                    currentRow++;
                    wallHitsCount++;
                    continue;
                }
                else if (currentCol >= board[currentRow].Length)
                {
                    currentRow++;
                    wallHitsCount++;
                    continue;
                }
            }

            if (board[currentRow][currentCol].Equals('$'))
            {
                coinsCount++;
            }
        }
        Console.WriteLine("Coins collected: {0}", coinsCount);
        Console.WriteLine("Walls hit: {0}", wallHitsCount);
    }
}