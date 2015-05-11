using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerroristsWin
{
    internal class TerroristsWin
    {
        private static char[] textForBombardment;

        private static void PrintBombardetDext()
        {
            foreach (var ch in textForBombardment)
                Console.Write(ch);
            Console.WriteLine();
        }

        private static void CalculationBobmb(int start, int end, int bomb)
        {
            int beginning = start - bomb;
            int final = end + bomb;
            if (bomb == 0)
                return;

            if (beginning < 0)
                beginning = 0;
            else if (final > (textForBombardment.Length - 1))
                final = textForBombardment.Length - 1;

            for (int i = beginning; i <= final; i++)
                textForBombardment[i] = '.';
        }

        private static void Main(string[] args)
        {
            textForBombardment = Console.ReadLine().ToCharArray();
            int bombStart = 0;
            int bombEnd = 0;

            for (int a = 0; a < textForBombardment.Length; a++)
            {
                int sum = 0;
                int bombCapacity = 0;
                if (textForBombardment[a].Equals('|'))
                {
                    bombStart = a;
                    for (int b = a + 1; b < textForBombardment.Length; b++)
                    {
                        if (textForBombardment[b].Equals('|'))
                        {
                            bombEnd = b;
                            a = b;
                            bombCapacity = sum%10;
                            CalculationBobmb(bombStart, bombEnd, bombCapacity);
                            break;
                        }
                        sum += textForBombardment[b];
                    }
                }
            }
            PrintBombardetDext();
        }
    }
}