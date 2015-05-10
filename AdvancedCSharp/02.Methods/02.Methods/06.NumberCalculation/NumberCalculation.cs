using System;
using System.Linq;

class NumberCalculation
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split(',').Select(x => Double.Parse(x)).ToArray<double>();

        Console.WriteLine(GetMin(numbers));
        Console.WriteLine(GetMax(numbers));
        Console.WriteLine(GetAverage(numbers));
        Console.WriteLine(GetSum(numbers));
        Console.WriteLine(GetProduct(numbers));
    }

    public static int GetMin(int[] numbers)
    {
        Array.Sort(numbers);
        return numbers[0];
    }

    public static double GetMin(double[] numbers)
    {
        Array.Sort(numbers);
        return numbers[0];
    }

    public static int GetMax(int[] numbers)
    {
        Array.Sort(numbers);
        return numbers[numbers.Length-1];
    }

    public static double GetMax(double[] numbers)
    {
        Array.Sort(numbers);
        return numbers[numbers.Length - 1];
    }

    public static int GetAverage(int[] numbers)
    {
        int number = 0;
        foreach (int i in numbers)
            number += i;
        number = number/numbers.Length;
        return number;
    }

    public static double GetAverage(double[] numbers)
    {
        double number = 0.0;
        foreach (double i in numbers)
            number += i;
        number = number / numbers.Length;
        return number;
    }

    public static int GetSum(int[] numbers)
    {
        int number = 0;
        foreach (int i in numbers)
            number += i;
        return number;
    }

    public static double GetSum(double[] numbers)
    {
        double number = 0.0;
        foreach (double i in numbers)
            number += i;
        return number;
    }

    public static int GetProduct(int[] numbers)
    {
        int number = 1;
        foreach (int i in numbers)
            number *= i;
        return number;
    }

    public static double GetProduct(double[] numbers)
    {
        double number = 1.0;
        foreach (double i in numbers)
            number *= i;
        return number;
    }
}