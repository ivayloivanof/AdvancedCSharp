using System;
using System.IO;

class CopyBinaryFile
{
    private static string imagePath = @"../../fire.jpg";
    private static string newImagePath = @"../../fire-new.jpg";

    static void Main()
    {
        using (var source = new FileStream(imagePath, FileMode.Open))
        {
            using (var destination = new FileStream(newImagePath, FileMode.Create))
            {
                double fileLength = source.Length;
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = source.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }

                    destination.Write(buffer, 0, readBytes);

                    Console.WriteLine("{0:P}", Math.Min(source.Position / fileLength, 1));
                }
            }
        }
    }
}