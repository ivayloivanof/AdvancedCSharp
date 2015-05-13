using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
            int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
            int[] sequenceThree = { 1, 1, 1 };


            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbour(sequenceOne));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbour(sequenceTwo));
            Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbour(sequenceThree));
        }

        static int GetIndexOfFirstElementLargerThanNeighbour(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        return i;
                    }
                 
                }
                else if (i == numbers.Length - 1)
                {
                    if (numbers[i] > numbers[i - 1])
                    {
                        return i;
                    }
                  
                }
                else
                {
                    if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                    {
                        return i;
                    }
                 
                }
            }
            return -1;
        }
    }
}
