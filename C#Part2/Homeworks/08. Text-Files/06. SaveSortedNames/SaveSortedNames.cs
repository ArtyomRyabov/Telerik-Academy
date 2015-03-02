// Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

namespace P06.SaveSortedNames
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Text;

    class SaveSortedNames
    {
        static void Main()
        {
            System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(1251);

            List<string> namesList = new List<string>();

            ReadFile(namesList);

            namesList.Sort();

            WriteToFile(namesList);
        }

        private static void WriteToFile(List<string> namesList)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\sorted_names.txt", false, Encoding.GetEncoding(1251)))
            {
                foreach (string name in namesList)
                {
                    writer.WriteLine(name);
                }
            }
        }

        private static void ReadFile(List<string> namesList)
        {
            using (StreamReader reader = new StreamReader(@"..\..\names.txt", Encoding.GetEncoding(1251)))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    namesList.Add(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
