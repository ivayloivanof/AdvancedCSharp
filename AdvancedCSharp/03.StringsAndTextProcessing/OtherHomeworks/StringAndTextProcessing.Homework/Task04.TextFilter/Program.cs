using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ban = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string input = Console.ReadLine();
            for (int i = 0; i < ban.Length; i++)
            {
                input = input.Replace(ban[i], new string('*', ban[i].Length));
            }
            Console.WriteLine(input);
        }
    }
}
