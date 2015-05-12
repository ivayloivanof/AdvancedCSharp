using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestIncreasingSequence
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int counter = 1;
        int maxCounter = 1;
        int end = 0;

        Console.Write(numbers[0] + " ");
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                counter++;
                Console.Write(numbers[i] + " ");
            }
            else
            {
                counter = 1;
                Console.WriteLine();
                Console.Write(numbers[i] + " ");
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                end = i;
            }
        }
        Console.WriteLine();
        Console.Write("Longest: ");
        for (int j = end - maxCounter + 1; j <= end; j++)
        {
            Console.Write(numbers[j] + " ");
        }
        }
    }


