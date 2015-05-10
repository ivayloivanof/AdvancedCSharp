using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(',').Select(x => int.Parse(x)).ToArray<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
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
        //last position
        else if (position == numbers.Length - 1)
        {
            if (numbers[position - 1] < numbers[position])
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