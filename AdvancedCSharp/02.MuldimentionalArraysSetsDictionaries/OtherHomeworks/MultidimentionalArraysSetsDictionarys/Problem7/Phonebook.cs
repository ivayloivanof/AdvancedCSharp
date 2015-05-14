using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();
            while(true)
            {
                string input = Console.ReadLine();
                if (input == "search")
                    break;
                string[] command = input.Split('-').ToArray();
                try
                {
                    phonebook[command[0]].Add(command[1]);
                }
                catch
                {
                    phonebook.Add(command[0], new List<string> { command[1] });
                }

            }
            while(true)
            {
                string input = Console.ReadLine();
                if(phonebook.ContainsKey(input))
                {
                    foreach(var el in phonebook[input])
                    Console.WriteLine("{0} -> {1}",input,el);
                }
                else Console.WriteLine("Contact " + input + " does not exist.");
            }
        }
    }
}
