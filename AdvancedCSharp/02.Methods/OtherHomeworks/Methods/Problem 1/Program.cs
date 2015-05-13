using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static int Getmax(int min)
        {
            int Firstnumber = int.Parse(Console.ReadLine());
            int Lastnumber = int.Parse(Console.ReadLine());
            int max = Getmax(Math.Min(Firstnumber,Lastnumber));
            return 0;
        }
    }
}
