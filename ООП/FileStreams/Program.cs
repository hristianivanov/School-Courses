using System.Data;
using System.Text;

namespace FileStreams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3
            int parts = int.Parse(Console.ReadLine()!);
            var stream = new FileStream("../../../lorenpsum.txt", FileMode.Open);

            bool changed;
            if(changed = true)
            {
                Console.WriteLine(changed);
            }

            byte[] buffer = new byte[stream.Length / parts];
            int cpt = 1;

            for (int i = 0; i < parts; i++)
            {
                int bytesRead = stream.Read(buffer);

                if (bytesRead == 0)
                    break;

                string fileName = $"Part{cpt}.txt";
                using var partStream = new FileStream("../../../" + fileName, FileMode.Create);
                partStream.Write(buffer);
                
                cpt++;
            }
            //while (true)
            //{
            //    int cnt = stream.Read(buffer);

            //    if (cnt == 0)
            //        break;
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine($"Part {cpt}"); cpt++;
            //    Console.ForegroundColor = ConsoleColor.White;
            //    for (int i = 0; i < buffer.Length; i++)
            //        Console.Write((char)buffer[i]);
            //    Console.WriteLine();
            //}

            //stream.Close();
            //try
            //{
            //    var sourcePath = "../../../cat.jpg";
            //    var destinationPath = "../../../copy.jpg";

            //    var sourceStream = new FileStream(sourcePath, FileMode.Open);
            //    var destinationStream = new FileStream(destinationPath, FileMode.Create);

            //    byte[] buffer = new byte[4096];
            //    int bytesRead;

            //    while (sourceStream.Read(buffer) > 0)
            //    {
            //        destinationStream.Write(buffer);
            //    }

            //    sourceStream.Close();
            //    destinationStream.Close();
            //}
            //catch (FileNotFoundException foe)
            //{
            //    Console.WriteLine();
            //}
            //catch(IOException ioe)
            //{
            //    Console.WriteLine();
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine();
            //}

        }
    }
}