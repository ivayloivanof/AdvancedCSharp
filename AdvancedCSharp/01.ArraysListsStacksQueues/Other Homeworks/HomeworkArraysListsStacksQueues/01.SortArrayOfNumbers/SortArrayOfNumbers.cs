using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayOfNumbers
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Sort(arr);
        Console.WriteLine(string.Join(" ", arr));
    }
}
