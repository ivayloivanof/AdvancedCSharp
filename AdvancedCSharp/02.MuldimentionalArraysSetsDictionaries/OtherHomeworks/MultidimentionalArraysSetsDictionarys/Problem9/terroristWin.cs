using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem9
{
    class terroristWin
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commands = input.Split('|');
            string[] bombs = new string[commands.Length / 2];
            bombs = Bombs(commands);
            char[] chars = input.ToCharArray();
           
            int bombIndex = 0;
            for (int i = 0; i < chars.Length; i++)
            {
                if(chars[i]=='|')
                {
                    int range = CalcBombRange(bombs[bombIndex]);

                    for (int j = i; j >= i-range; j--)
                    {
                        try
                        {
                            chars[j] = '.';
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    for (int j = i; j <= (i + range+bombs[bombIndex].Length+1); j++)
                    {
                        try
                        {
                            chars[j] = '.';
                        }
                        catch
                        {
                            continue;
                        }
                    }


                    bombIndex++;
                    
                }
                
            }
            foreach(var el in chars)
            {
                Console.Write(el);
            }
            Console.WriteLine();
            
            
            

        }
        static string[] Bombs (string[] commands)
        {
            string[] bombs = new string[commands.Length / 2];
            int bombindex = 0;
            for (int i = 0; i < commands.Length; i++)
            {

                if (i % 2 != 0)
                {
                    bombs[bombindex] = commands[i];
                    bombindex++;
                }
            }
            return bombs;
        }
        static int CalcBombRange(string bomb)
        {
            int range = 0;
            char[] currentChars = bomb.ToCharArray();
            foreach(var el in currentChars)
            { 
                range += el;
            }
            return range%10;
        }
    }
}
