using System;
class MatrixShuffling
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        int x1 = 0;
        int y1 = 0;
        int x2 = 0;
        int y2 = 0;
        string temp = String.Empty;
        string command = Console.ReadLine();
        while (command != "END")
        {
            string[] commandTokens = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (commandTokens.Length == 5 && commandTokens[0] == "swap")
            {
                x1 = int.Parse(commandTokens[1]);
                y1 = int.Parse(commandTokens[2]);
                x2 = int.Parse(commandTokens[3]);
                y2 = int.Parse(commandTokens[4]);

                if ((x1 >= 0 && x1 < rows) && (y1 >= 0 && y1 < cols)
                    && (x2 >= 0 && x2 < rows) && (y2 >= 0 && y2 < cols))
                {
                    temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;

                    Console.WriteLine("(After swapping {0} and {1}): ", matrix[x2, y2], matrix[x1, y1]);
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write("{0,2} ", matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

            command = Console.ReadLine();
        }
    }
}