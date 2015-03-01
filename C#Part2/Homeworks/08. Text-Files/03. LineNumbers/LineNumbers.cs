// Write a program that reads a text file and inserts line numbers in front of each of its lines.
// The result should be written to another text file.

namespace P03.LineNumbers
{
    using System;
    using System.IO;

    class LineNumbers
    {
        static void Main()
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\text_with_lines.txt"))
            {
                using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
                {
                    string line = reader.ReadLine();
                    int count = 1;

                    while (line != null)
                    {
                        writer.WriteLine("Line {0:D2}: {1}", count, line);
                        line = reader.ReadLine();
                        count++;
                    }
                }
            }
        }
    }
}
