using System;
using System.Linq;

class BinarySsearch
{
    static void Main()
    {
        int[] integer = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray<int>();
        int searchNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(BinarySearch(integer, searchNumber));
        //Console.WriteLine(Array.BinarySearch(integer, 0, integer.Length));
    }

    private static int BinarySearch(int[] numbers, int searchNumber)
    {
        Array.Sort(numbers);
        //int low = 0, high = numbers.Length - 1, position = 0;
        
        //while (low <= high)
        //{
        //    position = low + ((high - low) / 2);

        //    if (searchNumber == numbers[position])
        //        return position;
        //    else if (searchNumber < numbers[position])
        //        high = position - 1;
        //    else
        //        low = position + 1;
        //}

        int position = numbers.Length/2;
        bool loop = true;
        int notfound = -1;
        while (loop)
        {
            if (numbers[position] == searchNumber)
                return position;
            else if (numbers[position] < searchNumber)
                position++;
            else if (numbers[position] > searchNumber)
                position--;
            else
                loop = false;

            if (position < 0 || position > numbers.Length - 1)
                return notfound;
        }

        return notfound;
    }
}