using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string message = "It is not Linux, it is GNU/Linux. Linux is merely the kernel," +
                         " while GNU adds the functionality. " +
                         "Therefore we owe it to them by calling the OS GNU/Linux! " +
                         "Sincerely, a Windows client";
       string words = "Linux, Windows"; 


       Console.WriteLine(Regex.Replace(message, words.Replace(", ", "|"), m => new String('*', m.Length))); 

    }
}
