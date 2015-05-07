using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbersFindMinMaxAverage
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        double[] nums = numbers.Split().Select(double.Parse).ToArray();
        List<int> numberInteger = new List<int>();
        List<double> numberFloatPoints = new List<double>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 1 == 0)
            {
                numberInteger.Add((int) nums[i]);
            }
            else
            {
                numberFloatPoints.Add(nums[i]);
            }
        }

        GetNumbers(numberInteger);
        Console.WriteLine(" -> min: {0}, max: {1}, sum: {2}, avg: {3:f2}",
                                        numberInteger.Min(),
                                        numberInteger.Max(),
                                        NumbersSum(numberInteger),
                                        NumberAverage(numberInteger));
        GetNumbers(numberFloatPoints);
        Console.WriteLine(" -> min: {0:f2}, max: {1:f2}, sum: {2:f2}, avg: {3:f2}", 
                                        numberFloatPoints.Min(), 
                                        numberFloatPoints.Max(), 
                                        NumbersSum(numberFloatPoints),
                                        NumberAverage(numberFloatPoints));
    }

    private static void GetNumbers(List<int> numbers)
    {
        Console.Write("[");
        for (int i = 0; i < numbers.Count; i++)
        {
            if (i != numbers.Count - 1)
            {
                Console.Write("{0}, ", numbers[i]);
            }
            else
            {
                Console.Write("{0}", numbers[i]);
            }
        }
        Console.Write("]");
    }

    private static void GetNumbers(List<double> numbers)
    {
        Console.Write("[");
        for (int i = 0; i < numbers.Count; i++)
        {
            if (i != numbers.Count - 1)
            {
                Console.Write("{0:f2}, ", numbers[i]);
            }
            else
            {
                Console.Write("{0:f2}", numbers[i]);
            }
        }
        Console.Write("]");
    }

    private static double NumberAverage(List<int> numbers)
    {
        double average = 0.0;
        foreach (int num in numbers)
        {
            average += num;
        }
        average = average / numbers.Count;

        return average;
    }

    private static double NumberAverage(List<double> numbers)
    {
        double average = 0.0;
        foreach (double num in numbers)
        {
            average += num;
        }
        average = average / numbers.Count;

        return average;
    }

    private static double NumbersSum(List<int> numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    private static double NumbersSum(List<double> numbers)
    {
        double sum = 0.0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
}