using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    class fillTheMatrix
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = FillTheMatrixVerticaly(n);
            PrintMatrix(matrix);
            matrix = FillTheMatrixSnake(n);
            Console.WriteLine("---------------------");
            PrintMatrix(matrix);
        }
        static int[,] FillTheMatrixVerticaly(int n)
        {
            int index = 1;
            int[,] matrix = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[j, i] = index;
                    index++;
                }
            }

            return matrix;
        }
        static int[,] FillTheMatrixSnake(int n)
        {
            int index = 1;
            int j; 
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i+=2)
            {
                for (j = 0; j < n; j++)
                {
                    matrix[j, i] = index;
                    index++;
                }
                for (int t = j-1; t>=0; t--)
                {
                    matrix[t, i+1] = index;
                    index++;
                }
            }

            return matrix;
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}",matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
