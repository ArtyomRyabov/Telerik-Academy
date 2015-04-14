// Write a program that extracts from a given text all sentences containing given word.

namespace P08.ExtractSentences
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();
            Console.WriteLine("\nEnter the word:");
            string word = " " + Console.ReadLine() + " ";

            Console.WriteLine("\nExtracted sentences:");
            Console.WriteLine(Extract(text, word));
        }

        private static string Extract(string text, string word)
        {
            StringBuilder extracted = new StringBuilder();
            string[] sentences = text.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Contains(word))
                {
                    extracted.Append(sentences[i] + '.');
                }
            }

            return extracted.ToString();
        }
    }
}
