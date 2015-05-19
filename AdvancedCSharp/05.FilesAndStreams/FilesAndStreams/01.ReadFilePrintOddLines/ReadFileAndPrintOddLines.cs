using System;
using System.IO;

class ReadFileAndPrintOddLines
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("../../test.txt"))
            {
                int loop = 0;
                while (true)
                {
                    String line = reader.ReadLine();
                    if (line == null)
                        break;

                    if (loop % 2 != 0)
                        Console.WriteLine(line);

                    loop++;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(ex.Message);
        }
    }
}