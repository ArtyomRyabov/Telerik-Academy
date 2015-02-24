// Write a program that reverses the words in given sentence.

namespace P13.ReverseSentence
{
    using System;
    using System.Text;

    class ReverseSentence
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', ',', '.', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] nonWords = text.Split(words, StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(words);

            Console.WriteLine("Result:");
            Console.WriteLine(ReverseTheWords(words, nonWords));
        }

        private static string ReverseTheWords(string[] words, string[] nonWords)
        {
            StringBuilder result = new StringBuilder();
            int maxLength = 0;

            if (words.Length >= nonWords.Length)
            {
                maxLength = words.Length;
            }
            else
            {
                maxLength = nonWords.Length;
            }

            for (int i = 0; i < maxLength; i++)
            {
                if (i < words.Length)
                {
                    result.Append(words[i]);
                }

                if (i < nonWords.Length)
                {
                    result.Append(nonWords[i]);
                }
            }

            return result.ToString();
        }
    }
}
