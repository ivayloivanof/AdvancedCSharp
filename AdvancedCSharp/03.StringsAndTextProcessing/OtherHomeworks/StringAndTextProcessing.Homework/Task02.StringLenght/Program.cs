using System;

namespace Task02.StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length < 20)
            {
                input = input + new string('*', 20 - input.Length);
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(input.Substring(0, 20));
            }
        }
    }
}
