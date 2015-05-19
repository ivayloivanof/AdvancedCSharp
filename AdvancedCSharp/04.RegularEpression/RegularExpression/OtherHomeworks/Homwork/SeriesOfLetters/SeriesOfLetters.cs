using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
class SeriesOfLetters
{
    static void Main()
    {
        string str = "aaaaabbbbbcdddeeeedssaa";
        string[] pattern = { "(a{2,})", "(b{2,})", "(d{2,})", "(e{2,})", "(s{2,})" };
        string[] replacer = { "a", "b", "d", "e", "s" };
        string result = "";
        for (int i = 0; i < pattern.Length; i++)
        {
            Regex regex = new Regex(pattern[i]);
            result = regex.Replace(str,replacer[i]);
            str = result;
        }
        Console.WriteLine(str);
    }
}
//Write a program that reads a string from the console and replaces all series of consecutive
//identical letters with a single one.
//PLS!!!!
//May be there it is easyest way to do that!!!! Place add in your coment when u check my Homework!!

