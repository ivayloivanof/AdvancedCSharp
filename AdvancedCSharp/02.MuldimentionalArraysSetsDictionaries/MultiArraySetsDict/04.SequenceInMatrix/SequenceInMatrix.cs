using System;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {
        string[,] matrix1 = {
                                {"ha", "fifi", "ho", "hi"},
                                {"fo", "ha", "hi", "xx"},
                                {"xxx", "ho", "ha", "xx"}
                            };
        string[,] matrix2 = 
                            {
                                {"s", "qq", "s"},
                                {"pp", "pp", "s"},
                                {"pp", "qq", "s"}
                            };

        //int[] field = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
        //string[,] matrix = new string[field[0] + 1, field[1] + 1];
        //CreateMatrix(field, matrix);
        //Console.WriteLine();
        //ConsoleWriteMatrix(matrix);

        Console.WriteLine(FindLongestSequenceInMatrix(matrix1));
        Console.WriteLine(FindLongestSequenceInMatrix(matrix2));
    }

    private static string[,] CreateMatrix(int[] field, string[,] matrix)
    {
        for (int i = 0; i <= field[0]; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            for (int j = 0; j <= field[1]; j++)
            {
                matrix[i, j] = numbers[j].Trim();
            }
        }
        return matrix;
    }

    private static void ConsoleWriteMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,5}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static string FindLongestSequenceInMatrix(string[,] matrix)
    {
        int result = 0;
        int max = 0;
        string maxStr = "";
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                string curr = matrix[rows, cols];
                int currRow = FindSequence(matrix, rows, cols, 0);
                int currDiag = FindSequence(matrix, rows, cols, 1);
                int currCol = FindSequence(matrix, rows, cols, 2);
                int temp = Math.Max(Math.Max(currRow, currCol), currDiag);
                if (temp > max)
                {
                    max = temp;
                    maxStr = curr;
                }
            }
            if (max == matrix.GetLength(0))
            {
                return FormResult(max, maxStr);
            }
        }
        return FormResult(max, maxStr);
    }

    static string FormResult(int num, string str)
    {
        string result = "";
        for (int i = 0; i < num; i++)
        {
            result += str + ", ";
        }
        result = result.Substring(0, result.Length - 2);
        return result;
    }

    static int FindSequence(string[,] matrix, int startRow, int startCol, int direction)
    {
        int count = -1;
        //in a row
        if (direction == 0)
        {
            count = 1;
            for (int i = startCol + 1; i < matrix.GetLength(1); i++)
            {
                if (matrix[startRow, i] == matrix[startRow, startCol])
                {
                    count++;
                }
            }
        }
        //in a diagonal
        else if (direction == 1)
        {
            count = 1;
            int diagonalSize = (matrix.GetLength(0) < matrix.GetLength(1)) ? matrix.GetLength(0) : matrix.GetLength(1);
            for (int i = startCol + 1; i < diagonalSize; i++)
            {
                if (matrix[i, i] == matrix[startRow, startCol])
                {
                    count++;
                }
            }
        }
        //in a column
        else if (direction == 2)
        {
            count = 1;
            for (int rows = startRow + 1; rows < matrix.GetLength(0); rows++)
            {
                if (matrix[rows, startCol] == matrix[startRow, startCol])
                {
                    count++;
                }
            }
        }
        return count;
    }
}