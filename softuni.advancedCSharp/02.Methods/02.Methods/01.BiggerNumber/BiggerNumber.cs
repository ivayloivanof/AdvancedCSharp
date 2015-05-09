using System;

internal class BiggerNumber
{
    private static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(GetMax(firstNumber,secondNumber));
    }

    public static int GetMax(int first, int second)
    {
        return (first >= second) ? first : second;
    }
}
