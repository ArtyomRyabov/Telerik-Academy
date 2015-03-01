// Write a program that reads a text file and prints on the console its odd lines.

namespace P01.OddLines
{
    using System;
    using System.IO;

    class OddLines
    {
        static void Main()
        {
            using (StreamReader reader = new StreamReader(@"..\..\OddLines.cs"))
            {
                byte count = 1;
                string line = reader.ReadLine();

                while (line != null)
                {
                    if (count % 2 == 1)
                    {
                        Console.WriteLine("Line {0:D2}: {1}", count, line);
                    }

                    count++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
