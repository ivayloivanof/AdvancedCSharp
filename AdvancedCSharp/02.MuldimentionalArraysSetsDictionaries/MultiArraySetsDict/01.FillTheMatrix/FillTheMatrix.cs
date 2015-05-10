using System;
class FillTheMatrix
{
    static void Main()
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());

        int[,] matrix = new int[row,col];
        FillMatrix(matrix);
        PrintMatrix(matrix);

    }

    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix[i,j]);
            }
            Console.WriteLine();
        }
    }

    private static int[,] FillMatrix(int[,] matrix)
    {
        int num = 1;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                matrix[j, i] = num;
                num++;
            }
        }
        return matrix;
    }
}