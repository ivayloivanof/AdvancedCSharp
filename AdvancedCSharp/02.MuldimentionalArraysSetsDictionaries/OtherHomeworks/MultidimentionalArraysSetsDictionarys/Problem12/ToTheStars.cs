using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem12
{
    class ToTheStars
    {
        static void Main(string[] args)
        {
            
            double[,] positions = new double[3, 2];
            string[] names = new string[3];

            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine().Split();
                names[i] = input[0];
                for (int j = 1; j < 3; j++)
                {
                    positions[i, j - 1] = double.Parse(input[j]);
                }

            }
            double[] startPos = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int moves = int.Parse(Console.ReadLine());

            double currentX = startPos[0];
            double currentY = startPos[1];
            
           
            
            for (double i = currentY; i <= currentY + moves; i++)
            {
                string currentLocation="space";
                for (int j = 0; j < 3; j++)
                {
                    if (currentX >= positions[j, 0] - 1 && currentX <= positions[j, 0] + 1)
                    {
                        if (i >= positions[j, 1] - 1 && i <= positions[j, 1] + 1)
                        {
                            currentLocation = names[j].ToLower();
                            
                        }
                    }
                       
                        
                }
                    

                Console.WriteLine(currentLocation);

            }
            
        }
    }
}
