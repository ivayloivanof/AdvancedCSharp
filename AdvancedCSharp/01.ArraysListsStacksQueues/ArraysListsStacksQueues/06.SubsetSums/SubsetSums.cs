using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static List<List<int>> subsets = new List<List<int>>();
    static int[] numbers;
    static int number;
    static bool solution = false;

    static void Main()
    {
        number = int.Parse(Console.ReadLine());
        numbers = Console.ReadLine().Split(' ').Select(int.Parse).Distinct().ToArray();

        List<int> subset = new List<int>();
        MakeSubset(0, subset);

        var sorted = subsets.OrderBy(x => x.Count);
        
        foreach (var item in sorted)
        {
            Console.WriteLine(" {0} = {1}", string.Join(" + ", item), number);
        }

        if (!solution)
            Console.WriteLine("No matching subsets.");
    }

    static void MakeSubset(int index, List<int> subset)
    {
        if (subset.Sum() == number && subset.Count > 0)
        {
            subsets.Add(new List<int>(subset));
            solution = true;
        }

        for (int i = index; i < numbers.Length; i++)
        {
            subset.Add(numbers[i]);
            MakeSubset(i + 1, subset); 
            subset.RemoveAt(subset.Count - 1);
        }
    }
}