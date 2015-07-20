namespace _01.BunkerBuster
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine().Split(' ');
            int[,] matrix = new int[int.Parse(matrixSize[0]), int.Parse(matrixSize[1])];
            int allBunkers = int.Parse(matrixSize[0]) * int.Parse(matrixSize[1]);

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                int[] number = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = number[cols];
                }
            }
            
            int row = 0;
            int col = 0;

            while (true)
            {
                string line = Console.ReadLine();
                if (!string.IsNullOrEmpty(line) && line.Contains("cease fire!"))
                {
                    break;
                }

                string[] fieldCommand = line.Split(' ');
                row = int.Parse(fieldCommand[0]);
                col = int.Parse(fieldCommand[1]);
                int powerBomb = Convert.ToInt32(Convert.ToChar(fieldCommand[2]));
                int smallPowerBomb = (powerBomb + 1) / 2;
                
                for (int rows = row > 0 ? row - 1 : row = 0; 
                    rows < matrix.GetLength(0); 
                    rows++)
                {
                    for (int cols = col > 0 ? col - 1 : col = 0; 
                        cols < matrix.GetLength(1); 
                        cols++)
                    {
                        if (rows <= row + 1 && cols <= col + 1)
                        {
                            if (rows == row && cols == col)
                            {
                                matrix[rows, cols] -= powerBomb;
                                continue;
                            }

                            matrix[rows, cols] -= smallPowerBomb;
                        }
                    }
                }
            }

            int destroyetBunkers = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    if (matrix[rows, cols] < 0)
                    {
                        destroyetBunkers++;
                    }
                }
            }

            double demage = 100.0 * destroyetBunkers / allBunkers;

            Console.WriteLine("Destroyed bunkers: {0}", destroyetBunkers);
            Console.WriteLine("Damage done: {0:F1} %", demage);
        }
    }
}
