using System;
using System.Linq;

class SortArrayOfNumbers
{
    static void Main()
    {
        var numbers = Console.ReadLine().Split(' ').Select(token => int.Parse(token));
        int[] arr = numbers.ToArray();
        Array.Sort(arr);
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}