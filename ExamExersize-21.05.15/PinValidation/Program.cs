using System;
using System.Linq;

namespace PinValidation
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            string gender = Console.ReadLine();
            string pin = Console.ReadLine();

            int[] digitForMultiply = {2, 4, 8, 5, 10, 9, 7, 3, 6};
            int[] checksum = new int[pin.Length];
            for (int i = 0; i < pin.Length; i++)
            {
                checksum[i] = int.Parse(pin[i].ToString());
            }


            Console.WriteLine();
        }
    }
}
