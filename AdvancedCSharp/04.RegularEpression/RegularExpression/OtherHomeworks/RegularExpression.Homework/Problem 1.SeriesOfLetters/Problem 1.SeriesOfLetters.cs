using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem_1.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string repl;
            string example;
            Regex regexRepl;
            for (int i = 0; i < input.Length; i++)
            {
                example = string.Format(@"{0}+", input[i]);
                repl = string.Format(@"{0}", input[i]);
                regexRepl = new Regex(example);
                input = regexRepl.Replace(input, repl);
            }
            Console.WriteLine(input);
        }
    }
}
