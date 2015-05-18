using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Task06.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            decimal totalSum = 0;
            foreach (var word in input)
            {
                decimal curDig = decimal.Parse(word.Substring(1, word.Length - 2));
                decimal curSum = 0;
                if (char.IsUpper(word[0]))
                {
                    curSum = curDig / (decimal)((char)(word[0] - 64));
                }
                else
                {
                    curSum = curDig * (decimal)((char)(word[0] - 96));
                }
                if (char.IsUpper(word[word.Length - 1]))
                {
                    curSum = curSum - (decimal)((char)(word[word.Length - 1] - 64));
                }
                else
                {
                    curSum = curSum + (decimal)((char)(word[word.Length - 1] - 96));
                }
                totalSum += curSum;
            }
            Console.WriteLine("{0:F2}", totalSum);
        }
    }
}
