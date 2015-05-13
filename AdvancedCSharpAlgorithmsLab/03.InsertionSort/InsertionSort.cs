using System;
using System.Linq;

class InsertionSort
{
    static void Main()
    {
        int[] integer = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
        Console.WriteLine(String.Join(" ", PerformInsertionSort(integer)));
    }

    static int[] PerformInsertionSort(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            for (int j = i + 1; j > 0; j--)
            {
                if (inputArray[j - 1] > inputArray[j])
                {
                    int temp = inputArray[j - 1];
                    inputArray[j - 1] = inputArray[j];
                    inputArray[j] = temp;
                }
            }
        }
        return inputArray;
    }
}