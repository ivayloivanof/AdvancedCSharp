using System;
using System.IO;

class SlicingFile
{
    private static string pathDir = @"../../Part-";

    static void Main()
    {

        string[] partsText = Console.ReadLine().Split('=');
        string pathFile = @"../../silicon.mp4";//Console.ReadLine();    //get file path
        double parts = Convert.ToInt32(partsText[1]);   //get number of parts

        using (var source = new FileStream(pathFile, FileMode.Open))
        {
            for (int i = 0; i < parts; i++)
            {
                using (var destination = new FileStream(pathDir+i, FileMode.Create))
                {
                    double lenght = source.Length;  //get file lenght
                    double newPart = lenght / parts;  //certain size

                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                            break;
                        if (newPart >= destination.Length)
                        {
                            destination.Write(buffer, 0, readBytes);
                            Console.WriteLine("{0:P}", Math.Min(source.Position / lenght, 1));
                        }

                        
                    }
                }
            }
        }
    }
}