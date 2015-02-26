// Write a program that reads a string from the console and lists all different words in the string 
// along with information how many times each word is found.

namespace P22.WordsCount
{
    using System;
    using System.Collections.Generic;

    class WordsCount
    {
        static void Main()
        {
            string text = "Write a program that reads a string from the console and lists all different " +
                          "words in the string along with information how many times each word is found." +
                          "Write a program that reads a string from the console and lists all different " +
                          "words in the string along with information how many times each word is found." +
                          "Write a program that reads a string from the console and lists all different " +
                          "words in the string along with information how many times each word is found.";

            string[] splitText = text.ToLower().Trim('.').Split(' ', '.');

            Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();
            AddWordsToDictionary(splitText, wordsDictionary);

            foreach (var word in wordsDictionary)
            {
                Console.WriteLine("The word \"{0}\" appears {1} time(s)", word.Key, word.Value); 
            }
        }

        private static void AddWordsToDictionary(string[] splitText, Dictionary<string, int> wordsDictionary)
        {
            foreach (string word in splitText)
            {
                if (wordsDictionary.ContainsKey(word))
                {
                    wordsDictionary[word]++;
                }
                else
                {
                    wordsDictionary.Add(word, 1);
                }
            }
        }
    }
}
