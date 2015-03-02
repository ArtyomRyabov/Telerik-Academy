/* Write a program that deletes from given text file all odd lines.
   The result should be in the same file.
  
   Input:
         1
         2
         3
         4
         5
         6
         7
         8
         9
         10
 */

namespace P09.DeleteOddLines
{
    using System;
    using System.IO;
    using System.Text;
    
    class DeleteOddLines
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();

            SelectEvenLines(text);

            WriteTextInFile(text);
        }

        private static void WriteTextInFile(StringBuilder text)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\text.txt"))
            {
                writer.Write(text);
            }
        }

        private static void SelectEvenLines(StringBuilder text)
        {
            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                string line = reader.ReadLine();
                int count = 1;

                while (line != null)
                {
                    if (count % 2 == 0)
                    {
                        text.Append(line);

                        if (!reader.EndOfStream)
                        {
                            text.Append("\r\n");
                        }
                    }

                    line = reader.ReadLine();
                    count++;
                }
            }
        }
    }
}
