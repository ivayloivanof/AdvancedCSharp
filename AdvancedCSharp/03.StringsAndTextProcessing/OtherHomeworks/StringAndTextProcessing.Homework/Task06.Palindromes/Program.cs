using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task06.Palindromes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string splitString = @"[\s\p{P}]";
            string[] split = Regex.Split(input, splitString);
            List<string> lexicography = new List<string>();
            foreach (var word in split)
            {
                IsPalindrome(word);
                if (IsPalindrome(word) && word != String.Empty)
                {
                    lexicography.Add(word);
                }
            }
            lexicography.Sort();
            Console.WriteLine(String.Join(", ", lexicography));
        }
        public static bool IsPalindrome(string value)
        {
            int min = 0;
            int max = value.Length - 1;
            while (true)
            {

                if (min > max)
                {
                    return true;
                }
                char a = value[min];
                char b = value[max];
                if (a != b)
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}