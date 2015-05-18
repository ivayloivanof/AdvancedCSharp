using System;
using System.Linq;
using System.Text.RegularExpressions;


class Program
{
    static void Main()
    {
        string str = Console.ReadLine();
        string strAll = "";
        
        foreach (Match item in Regex.Matches(str, @"\w+"))
            if (IsPalindrome(item.Value))
                strAll += item + ";";

        string[] strArray = strAll.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Array.Sort(strArray);

        int i;
        for (i = 0; i < strArray.Length; i++)
            if (i == strArray.Length - 1) Console.Write(strArray[i]); else Console.Write(strArray[i] + ", ");

        Console.WriteLine();
    }

    static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
            if (str[i] != str[str.Length - 1 - i])
                return false;

        return true;
    }
}
