using System;
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char[' '],StringSplitOptions.RemoveEmptyEntries);

        double result = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char currentSymbol = char.Parse(input[i]);
            if (currentSymbol >= 'A' && currentSymbol <= 'Z')
            {
                result += (currentSymbol - 'A') + 1;
            }
            else if (currentSymbol >= 'a' && currentSymbol <= 'z')
            {
               
            }
        }
    }
}

//private static double executeFirstChar(char c, double number) {
//        if (c >= 65 && c <= 90) {
//            return number / (c - 64);
//        } else {
//            return number * (c - 96);
//        }
//    }

//    private static double executeSecondChar(char c, double number) {
//        if (c >= 65 && c <= 90) {
//            return number - (c - 64);
//        } else {
//            return number + (c - 96);
//        }

//public static int GetPositionInAlphabet(char ch) {
//        if (Character.isUpperCase(ch)) {
//            return ((int) ch - (int) 'A') + 1;
//        } else {
//            return ((int) ch - (int) 'a') + 1;
//        }
//    }