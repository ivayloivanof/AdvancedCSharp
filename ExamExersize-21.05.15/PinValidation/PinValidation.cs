using System;

namespace PinValidation
{
    class PinValidation
    {
        static void Main()
        {
            string name = Console.ReadLine();
            string gender = Console.ReadLine();
            string pin = Console.ReadLine();

            bool correct = true;

            int[] digitForMultiply = {2, 4, 8, 5, 10, 9, 7, 3, 6};
            int[] checksum = new int[pin.Length];
            int sum = 0;
            for (int i = 0; i < pin.Length; i++)
            {
                checksum[i] = int.Parse(pin[i].ToString());
                if (i < pin.Length - 1)
                    sum += checksum[i]*digitForMultiply[i];
            }

            int gend = checksum[pin.Length - 2];
            if ((gend%2 == 0 && gender == "male") || (gend%2 != 0 && gender == "female"))
            {
                sum = sum % 11;
                if (sum == 10)
                    sum = 0;

                if (checksum[pin.Length - 1] != sum)
                    correct = false;
            }
            else
            {
                correct = false;
            }

            if (correct)
                Console.WriteLine("{{\"name\":\"{0}\",\"gender\":\"{1}\",\"pin\":\"{2}\"}}", name, gender, pin);
            else
                Console.WriteLine("<h2>Incorrect data</h2>");
        }
    }
}



