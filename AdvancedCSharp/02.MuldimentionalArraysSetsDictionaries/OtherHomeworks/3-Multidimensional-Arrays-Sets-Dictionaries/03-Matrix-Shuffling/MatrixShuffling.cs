using System;
class MatrixShuffling
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        int row = 0;
        int col = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            else if (!input.StartsWith("swap"))
            {
                if (input.Split(' ').Length > 1)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                {
                    matrix[row, col] = input;
                    if (col == cols - 1)
                    {
                        col = 0;
                        row++;
                    }
                    else
                    {
                        col++;
                    }
                }
            }
            else
            {
                var coordinates = input.Split(' ');
                int x1 = int.Parse(coordinates[1]);
                int y1 = int.Parse(coordinates[2]);
                int x2 = int.Parse(coordinates[3]);
                int y2 = int.Parse(coordinates[4]);
                if (x1 < rows && x2 < rows && y1 < cols && y2 < cols)
                {
                    string swap = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = swap;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
        
    }
}

