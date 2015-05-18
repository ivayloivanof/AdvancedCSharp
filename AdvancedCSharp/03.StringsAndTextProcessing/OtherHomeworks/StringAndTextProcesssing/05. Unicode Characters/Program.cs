using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine(ConvertToUnicode(Console.ReadLine()));
    }

    static string ConvertToUnicode(string str)
    {
        StringBuilder utf = new StringBuilder(str.Length * 6);

        foreach (char c in str)
            utf.AppendFormat("\\u{0:X4}", (int)c);

        return utf.ToString();
    }
}

