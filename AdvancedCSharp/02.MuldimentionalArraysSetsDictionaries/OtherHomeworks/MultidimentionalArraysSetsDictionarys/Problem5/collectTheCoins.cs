using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class collectTheCoins
    {
        static void Main(string[] args)
        {
            char[][] jaggedArray = new char[4][];
            for (int i = 0; i < 4; i++)
            {
                jaggedArray[i] = FillTheRows();
            }
            char[] commands = Console.ReadLine().ToCharArray();
            int currentRow=0;
            int currentCol=0;
            int coins=0;
            int borderHit=0;
            foreach(var el in commands)
            {
                if(el=='V')
                {
                    if(currentRow+1<=3)
                    {
                        if (jaggedArray[currentRow + 1].Length >= currentCol)
                        {
                            currentRow++;
                        }
                        else
                            borderHit++;
                    }
                    else
                    {
                        borderHit++;
                        continue;
                    }
                }

                if(el=='^')
                {
                    if (currentRow - 1 >= 0)
                    {
                        if (jaggedArray[currentRow - 1].Length >= currentCol)
                        {
                            currentRow--;
                        }
                        else
                            borderHit++;
                    }
                    else
                    {
                        borderHit++;
                        continue;
                    }
                }

                if(el=='>')
                {
                    if(currentCol+1<=jaggedArray[currentRow].Length-1)
                    {
                        currentCol++;
                    }
                    else
                    {
                        borderHit++;
                        continue;
                    }
                }

                if(el=='<')
                {
                    if (currentCol - 1 >= 0)
                    {
                        currentCol--;
                    }
                    else
                    {
                        borderHit++;
                        continue;
                    }
                }
                if (jaggedArray[currentRow][currentCol] == '$')
                    coins++;


            }
            Console.WriteLine("Coins collected: " + coins);
            Console.WriteLine("Walls hit: "+borderHit);
        }
        static char[] FillTheRows()
        {

            char[] matrix = Console.ReadLine().ToCharArray();


            return matrix;
        }
    }
}
