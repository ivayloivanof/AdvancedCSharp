using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(IsLargerThanNumber(numbers,i));
            }

        }
        static bool IsLargerThanNumber(int[] numbers,int  i)
        {
            if (i == 0)
            {
                if (numbers[i] > numbers[i+1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (i == numbers.Length - 1)
            {
                if (numbers[i] > numbers[i - 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (numbers[i] > numbers[i-1] && numbers[i] > numbers[i+1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
