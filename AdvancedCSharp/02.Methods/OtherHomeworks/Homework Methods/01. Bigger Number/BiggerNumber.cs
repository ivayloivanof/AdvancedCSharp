using System;

class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);


    }

    static int GetMax(int firstNumber, int secondNumber)
    {
        int bigger;

        if (firstNumber > secondNumber)
            bigger = firstNumber;
        else
            bigger = secondNumber;
        return bigger;
    }
}

