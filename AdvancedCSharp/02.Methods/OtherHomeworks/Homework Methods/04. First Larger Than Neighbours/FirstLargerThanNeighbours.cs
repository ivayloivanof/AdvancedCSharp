using System;
using System.Collections.Generic;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }
    static int GetIndexOfFirstElementLargerThanNeighbours(int [] sequence)
    {
        int index = -1;
        if (sequence[0] > sequence[1])
            index = 0;
        else if (sequence[sequence.Length - 1] > sequence[sequence.Length - 2])
            index = sequence.Length - 1;
        else
        {
            for (int i = 1; i < sequence.Length; i++)
            {
                if (sequence[i] > sequence[i - 1] && sequence[i] > sequence[i + 1])
                {
                    index = i;
                    break;
                }
            }
        }
        return index;
    }
}

