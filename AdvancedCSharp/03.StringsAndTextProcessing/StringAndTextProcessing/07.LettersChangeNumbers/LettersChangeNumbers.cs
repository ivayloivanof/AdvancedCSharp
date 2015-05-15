using System;
class LettersChangeNumbers
{
    static void Main()
    {
        string[] sequence = Console.ReadLine().Replace("   ", " ").Split(' ');
        double resultAll = 0.0;

        //A12b s17G
        //12/1=12, 12+2=14, 17*19=323, 323–7=316, 14+316=330

        for (int i = 0; i < sequence.Length; i++)
        {
            char firstLeter = Convert.ToChar(sequence[i].Substring(0, 1));
            char lastLetter = Convert.ToChar(sequence[i].Substring(sequence[i].Length - 1));
            double number = Convert.ToDouble(sequence[i].Substring(1, sequence[i].Length - 2));
            double result = 0;

            if (firstLeter >= 65 && firstLeter <= 90)
                result = DivideNumber(firstLeter-64, number);
            if (firstLeter >= 97 && firstLeter <= 122)
                result = MultiplyNumber(firstLeter - 96, number);
            if (lastLetter >= 65 && lastLetter <= 90)
                result = SubtractNumber(lastLetter - 64, result);
            if (lastLetter >= 97 && lastLetter <= 122)
                result = AddNumber(lastLetter - 96, result);
            resultAll += result;
        }
        Console.WriteLine("{0:F2}", resultAll);
    }

    public static double DivideNumber(int firstLetter, double number)
    {
        if (firstLetter > number)
            return firstLetter/number;
        else
            return number/firstLetter;
    }

    public static double MultiplyNumber(int firstLetter, double number)
    {
        return firstLetter*number;
    }

    public static double SubtractNumber(int lastLetter, double number )
    {
        if (lastLetter > number)
            return lastLetter - number;
        else
            return number - lastLetter;
    }

    public static double AddNumber(int lastLetter, double number)
    {
        return lastLetter + number;
    }
}