using System;
class LettersChangeNumbers
{
    static void Main()
    {
        string[] sequence = Console.ReadLine().Split(' ');

        //A12b s17G
        //12/1=12, 12+2=14, 17*19=323, 323–7=316, 14+316=330

        for (int i = 0; i < sequence.Length; i++)
        {
            char firstLeter = Convert.ToChar(sequence[i].Substring(0, 1));
            char lastLetter = Convert.ToChar(sequence[i].Substring(sequence[i].Length - 1));
            int number = Convert.ToInt32(sequence[i].Substring(1, sequence[i].Length - 2));

            if (firstLeter >= 65 && firstLeter <= 90)
                DivideNumber(firstLeter-64, number);
            if (firstLeter >= 97 && firstLeter <= 122)
                MultiplyNumber(firstLeter - 96, number);
            if (lastLetter >= 65 && lastLetter <= 90)
                SubtractNumber(lastLetter - 64, number);
            if (lastLetter >= 97 && lastLetter <= 122)
                AddNumber(lastLetter - 96, number);

        }
        Console.WriteLine();
    }

    public static int DivideNumber(int firstLetter, int number)
    {
        if (firstLetter > number)
            return firstLetter/number;
        else
            return number/firstLetter;
    }

    public static int MultiplyNumber(int firstLetter, int number)
    {
        return firstLetter*number;
    }

    public static int SubtractNumber(int lastLetter, int number )
    {
        if (lastLetter > number)
            return lastLetter - number;
        else
            return number - lastLetter;
    }

    public static int AddNumber(int lastLetter, int number)
    {
        return lastLetter + number;
    }
}