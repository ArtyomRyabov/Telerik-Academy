// Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
// Ensure it will work with large files (e.g. 100 MB).

namespace P07.ReplaceSubstring
{
    using System;
    using System.IO;

    class ReplaceSubstring
    {
        static void Main()
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\text.txt"))
            {
                using (StreamReader reader = new StreamReader(@"..\..\text.txt"))    // text: start finishstart startstartfinish
                {
                    string text = reader.ReadLine();

                    while (text != null)
                    {
                        text = text.Replace("start", "finish");
                        writer.WriteLine(text);
                        text = reader.ReadLine();
                    }
                }
            }
        }
    }
}
