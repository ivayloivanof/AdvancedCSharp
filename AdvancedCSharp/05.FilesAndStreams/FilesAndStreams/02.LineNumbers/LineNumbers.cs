using System;
using System.IO;
class LineNumbers
{
    private static String pathInput = "../../input.txt";
    private static String pathOutput = "../../output.txt";

    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader(pathInput))
            {
                using (StreamWriter writer = new StreamWriter(pathOutput))
                {
                    int i = 1;
                    while (true)
                    {
                        String line = reader.ReadLine();
                        if (line == null)
                            break;
                        String lineNumber = i + " ";

                        writer.WriteLine(lineNumber + line);
                        i++;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}