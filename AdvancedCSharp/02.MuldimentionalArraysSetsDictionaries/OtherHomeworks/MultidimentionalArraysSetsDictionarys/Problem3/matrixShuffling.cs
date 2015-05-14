using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class matrixShuffling
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size, splited by a space");
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = FillTheMatrix(size[0], size[1]);
            
            while(true)
            {
                Console.WriteLine("Enter command: ");
                string command = Console.ReadLine();
                if(command=="END")//check if "END" is entered
                    break;
                string[] splitedCommands = Commands(command);
                if (splitedCommands[0] != "swap")//check if the command starts with "swap"
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    try  //if we enter too big coordinates and get exception out of array
                    {
                        string container;
                        container = matrix[int.Parse(splitedCommands[1]), int.Parse(splitedCommands[2])];
                        matrix[int.Parse(splitedCommands[1]), int.Parse(splitedCommands[2])] = matrix[int.Parse(splitedCommands[3]), int.Parse(splitedCommands[4])];
                        matrix[int.Parse(splitedCommands[3]), int.Parse(splitedCommands[4])] = container;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                }
                PrintMatrix(matrix);

            }
            
        }
        static void PrintMatrix(string[,] matrix) //print the matrix
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
        static string[] Commands (string input) // split the input string into array
        {
            string[] commandsSplited = new string[5];
            try // if we get too large input
            {
                commandsSplited = input.Split().ToArray();
            }
            catch
            {
                Console.WriteLine("Invalid input!");
                return null;
            }
            return commandsSplited;
        }
        static string[,] FillTheMatrix(int n, int m)
        {

            string[,] matrix = new string[n, m];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter strings for row {0}",i+1);
                string[] currentRow = FillTheRows(m);//splited row into new array
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = currentRow[j];
                }

            }
            

            return matrix;
        }
        static string[] FillTheRows(int m)
        {

            string[] matrix = Console.ReadLine().Split(' ').ToArray();


            return matrix;
        }
    }
}
