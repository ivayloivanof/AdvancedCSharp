using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            bool neighbours = IsLargerThanNeighbours(numbers, i);
            if (neighbours)
            {
                Console.WriteLine(i);
                break;
            }

            if (neighbours == false && i == numbers.Length - 1)
                Console.WriteLine(-1);
        }
    }

    public static bool IsLargerThanNeighbours(int[] numbers, int position)
    {
        bool neighbours = false;

        //first position
        if (position == 0)
        {
            if (numbers[position] > numbers[position + 1])
                neighbours = true;
        }
        else
        {
            if (numbers[position - 1] < numbers[position] && numbers[position] > numbers[position + 1])
                neighbours = true;
        }

        return neighbours;
    }
}