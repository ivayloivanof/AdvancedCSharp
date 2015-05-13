using System;
using System.Collections.Generic;
    
class NumberCalculations
{
   static void Main()
   {
       double[] numbers = { 2, 4.5, 7.845, 3, 6.7235 };
       Console.WriteLine("sum = {0}", GetSum(numbers));
       Console.WriteLine("product = {0}", GetProduct(numbers));
       Console.WriteLine("average = {0}", GetAverage(numbers));
       Console.WriteLine("max = {0}", GetMax(numbers));
       Console.WriteLine("min = {0}", GetMin(numbers));

   }
    static double GetSum( double [] numbers)
   {
        double sum = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
            sum += numbers[i];
        return sum;
   }
    static double GetProduct(double[] numbers)
    {
        double product = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
            product *= numbers[i];
        return product;
    }
    static double GetAverage(double[] numbers)
    {
        double average = GetSum(numbers) / numbers.Length;
        return average;
    }
    static double GetMax(double[] numbers)
    {
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (max < numbers[i])
                max = numbers[i];
        }
        return max;
    }
    static double GetMin(double[] numbers)
    {
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (min > numbers[i])
                min = numbers[i];
        }
        return min;
    }
}

