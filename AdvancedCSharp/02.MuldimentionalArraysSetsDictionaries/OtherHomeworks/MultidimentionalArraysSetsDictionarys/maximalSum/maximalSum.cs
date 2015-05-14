using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximalSum
{
    class maximalSum
    {
        static void Main(string[] args)
        {
            
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[,] matrix = FillTheMatrix(size[0], size[1]);

        }
        static int[,] FillTheMatrix(int n, int m)
        {

            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {

                int[] currentRow = FillTheRows(m);//splited row into new array
                for (int j = 0; j < currentRow.Length; j++)
                {
                    try
                    {
                        matrix[i, j] = currentRow[j];
                    }
                    catch
                    {
                        Console.WriteLine("Too many elements!");
                        Console.WriteLine("Extra elements were removed!");
                        
                    }
                }

            }
            FindMaxSum(matrix);

            return matrix;
        }
        static int[] FillTheRows(int m)
        {

            int[] matrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            

            return matrix;
        }
        static void FindMaxSum(int[,] matrix)
        {
            int bestSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            Console.WriteLine("Sum = " +bestSum);
            PrintMatrix(matrix, startRow, startCol);//prints the part with maximal sum


        }
        static void PrintMatrix(int[,] matrix, int n, int m)//prints the part with maximal sum
        {
            for (int row = n; row < n+3; row++)
            {
                for (int col = m; col < m+3; col++)
                {
                    Console.Write("{0,-3}",matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }

}
