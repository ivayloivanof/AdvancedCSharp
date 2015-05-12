using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayOfNumbersUsingSelectionSort
{
    static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int n = arr[i];
                    arr[i] = arr[j];
                    arr[j] = n;
                }
            }
        }
        Console.WriteLine(string.Join(" ", arr));
    }
}

