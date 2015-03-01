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
            Encoding encoding = System.Text.Encoding.GetEncoding(1251);

            using (StreamWriter writer = new StreamWriter(@"..\..\concatenated_files.txt", false, encoding))
            {
                using (StreamReader firstFileReader = new StreamReader(@"..\..\first_file.txt", encoding))
                {
                    string line = firstFileReader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine(line);
                        line = firstFileReader.ReadLine();
                    }
                }

                using (StreamReader secondFileReader = new StreamReader(@"..\..\second_file.txt", encoding))
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
