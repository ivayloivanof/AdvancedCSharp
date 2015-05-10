using System;
using System.Collections.Generic;

class SortArrayUsingSelectionSort
{
    static void Main()
    {
        List<int> numbers = new List<int>(Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse));

        for (int i = 0; i < numbers.Count - 1; i++)
        {
            for (int j = 0; j < numbers.Count - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int tmp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = tmp;
                }
            }
        }

        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}