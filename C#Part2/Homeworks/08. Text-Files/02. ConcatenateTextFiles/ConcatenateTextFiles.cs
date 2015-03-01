// Write a program that concatenates two text files into another text file.

namespace P02.ConcatenateTextFiles
{
    using System;
    using System.IO;
    
    class ConcatenateTextFiles
    {
        static void Main()
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\concatenated_files.txt", false))
            {
                using (StreamReader firstFileReader = new StreamReader(@"..\..\first_file.txt"))
                {
                    string line = firstFileReader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = firstFileReader.ReadLine();
                    }
                }

                using (StreamReader secondFileReader = new StreamReader(@"..\..\second_file.txt"))
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
