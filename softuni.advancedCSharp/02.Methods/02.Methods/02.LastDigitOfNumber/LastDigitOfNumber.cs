using System;
using System.Linq;

class LastDigitOfNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(GetLastDigitOfWords(number));
    }

    public static string GetLastDigitOfWords(int number)
    {
        int num = Convert.ToInt32(number.ToString().AsEnumerable().Last().ToString()); //or easy = number % 10;
        string numbers = "";
        switch (num)
        {
            case 1: numbers = "one"; break;
            case 2: numbers = "two"; break;
            case 3: numbers = "tree"; break;
            case 4: numbers = "four"; break;
            case 5: numbers = "five"; break;
            case 6: numbers = "six"; break;
            case 7: numbers = "seven"; break;
            case 8: numbers = "eight"; break;
            case 9: numbers = "nine"; break;
            default: numbers = "zero"; break;
        }

        return numbers;
    }
}