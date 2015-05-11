using System;
using System.Collections.Generic;

class Phonebook
{
    static void Main()
    {
        Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();

        string contactAllInfo = Console.ReadLine();
        string[] contactTokens;
        string contactName = String.Empty;
        string contactNumber = String.Empty;

        while (contactAllInfo != "search")
        {
            contactTokens = contactAllInfo.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            contactName = contactTokens[0];
            contactNumber = contactTokens[1];
            if (!phonebook.ContainsKey(contactName))
                phonebook[contactName] = new List<string>();
            phonebook[contactName].Add(contactNumber);
            contactAllInfo = Console.ReadLine();
        }

        string contactSearch = Console.ReadLine();
        while (!String.IsNullOrEmpty(contactSearch))
        {
            if (phonebook.ContainsKey(contactSearch))
                Console.Write("{0} -> {1}", contactSearch, String.Join(", ", phonebook[contactSearch]));
            else
                Console.WriteLine("Contact {0} does not exist.", contactSearch);

            contactSearch = Console.ReadLine();
        }
    }
}