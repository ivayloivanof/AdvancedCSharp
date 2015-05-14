using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11
{
    class StringMatrixRotation
    {
        static void Main(string[] args)
        {
            int degrese = GetDegrese();
            //Console.WriteLine(degrese);
            List<string> matrix = generateMatrix();
            char[][] jaggedmatrix = new char[matrix.Count][];
            int maxsize = 0;
            for (int i = 0; i < matrix.Count; i++)//find the longest string.
            {
                if(matrix[i].Length>maxsize)
                { maxsize = matrix[i].Length; }
                jaggedmatrix[i]=matrix[i].ToCharArray();
            }
            char[,] finalMat = FinalMatrix(jaggedmatrix, maxsize);


            int repetition = degrese / 90;//n*90 degrese rotations
            for (int i = 0; i <repetition; i++)
            {
                finalMat = Rotate(finalMat);
            }
            
            
            PrintMatrix(finalMat);
            

            

        }
        static char[,] Rotate(char[,] mat)//rotates the matrix on 90 degrese
        {
            char[,] currentMatrix = new char[mat.GetLength(1), mat.GetLength(0)];
            int size = mat.GetLength(0) - 1;
            for (int row = 0; row < mat.GetLength(1); row++)
            {
                for (int col = 0; col < mat.GetLength(0); col++)
                {
                    currentMatrix[row, col] = mat[size - col, row];
                }
            }
            return currentMatrix;
        }

        private static void PrintMatrix(char[,] finalMat)
        {
            for (int i = 0; i < finalMat.GetLength(0); i++)
            {
                for (int j = 0; j < finalMat.GetLength(1); j++)
                {
                    Console.Write(finalMat[i, j]);
                }
                Console.WriteLine();
            }
        }
        static char[,] FinalMatrix(char[][] matrix,int maxsize)
        {
            char[,] finalMatrix = new char[matrix.GetLength(0),maxsize];

            for (int i = 0; i < finalMatrix.GetLength(0); i++)
			{
			     for (int j = 0; j < maxsize; j++)
			    {
                    try  //fills emplty cells with whitespace
                    {
                        finalMatrix[i, j] = matrix[i][j];
                    }
                    catch
                    {
                        finalMatrix[i, j] = ' ';
                    }
			    }
			}
            return finalMatrix;
        }
        

        private static List<string> generateMatrix()
        {
            List<string> matrix = new List<string>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "END")
                    break;
                matrix.Add(input);
            }
            return matrix;
        
        }
        static int GetDegrese ()
        {
            string[] input = Console.ReadLine().Split('(');            
            string[] secondSplit = input[1].Split(')');
            int degrese = int.Parse(secondSplit[0]);            
            return degrese;
        }
    }
}
