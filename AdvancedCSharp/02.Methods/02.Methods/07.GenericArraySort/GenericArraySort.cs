using System;
class GenericArraySort
{
    static void Main()
    {
        int[] numbers = {1, 3, 4, 5, 1, 0, 5};
        string[] strings = {"zaz", "cba", "baa", "azis"};
        DateTime[] dates = {new DateTime(2002, 3, 1), new DateTime(2015, 5, 6), new DateTime(2014, 1, 1)};

        SortArray(numbers);
        Console.WriteLine(String.Join(", ", numbers));
        SortArray(strings);
        Console.WriteLine(String.Join(", ", strings));
        SortArray(dates);
        Console.WriteLine(String.Join(", ", dates));
    }

    public static int[] SortArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    int tmp = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = tmp;
                }
            }
        }
        return numbers;
    }

    public static string[] SortArray(string[] strings)
    {
        Array.Sort(strings);
        return strings;
    }

    public static DateTime[] SortArray(DateTime[] dates)
    {
        Array.Sort(dates);
        return dates;
    }
}