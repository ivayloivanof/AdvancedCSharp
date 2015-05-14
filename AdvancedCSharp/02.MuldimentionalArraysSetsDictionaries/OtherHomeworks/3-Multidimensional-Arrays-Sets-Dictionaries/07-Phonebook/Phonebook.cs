using System;
using System.Collections.Generic;
class Phonebook
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "search")
            {
                break;
            }
            else
            {
                string[] contact = input.Split('-');
                phonebook.Add(contact[0], contact[1]);
            }
        }
        while (true)
        {
            string search = Console.ReadLine();
            if (search == string.Empty)
            {
                break;
            }
            else
            {
                string number = string.Empty;
                if(phonebook.TryGetValue(search, out number))
                {
                    Console.WriteLine("{0} -> {1}", search, number);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", search);
                }
            }
        }
    }
}

