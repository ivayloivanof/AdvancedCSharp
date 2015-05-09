using System;
class ReverseNumber
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine(GetReversedNumber(number));
    }

    public static double GetReversedNumber(double number)
    {
        string reverse = number.ToString();
        char[] charArray = reverse.ToCharArray();
        Array.Reverse(charArray);
        reverse = new string(charArray);
        return Convert.ToDouble(reverse);
    }
}
