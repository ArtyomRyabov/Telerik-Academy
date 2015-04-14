// Write a program that extracts from given XML file all the text without the tags.

namespace P10.ExtractTextFromXML
{
    using System;
    using System.IO;
    using System.Text;

    class ExtractTextFromXML
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            string line = string.Empty; 

            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 1; i < line.Length; i++)
                    {
                        if (line[i - 1] == '>')
                        {
                            do
                            {
                                text.Append(line[i]);
                                i++;
                            }
                            while (line[i] != '<');

                            Console.WriteLine(text.ToString());
                            text.Clear();
                        }
                    }
                }
            }
        }
    }
}
