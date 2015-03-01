// Write a program that concatenates two text files into another text file.

namespace P02.ConcatenateTextFiles
{
    using System;
    using System.IO;
    using System.Text;
    
    class ConcatenateTextFiles
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            using (StreamWriter writer = new StreamWriter(@"..\..\concatenated_files.txt", false, Encoding.UTF8))
            {
                using (StreamReader firstFileReader = new StreamReader(@"..\..\first_file.txt", Encoding.UTF8))
                {
                    string line = firstFileReader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = firstFileReader.ReadLine();
                    }
                }

                using (StreamReader secondFileReader = new StreamReader(@"..\..\second_file.txt", Encoding.UTF8))
                {
                    string line = secondFileReader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = secondFileReader.ReadLine();
                    }
                }
            }
        }
    }
}
