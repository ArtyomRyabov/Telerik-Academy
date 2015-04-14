using System;

class IndexOfLetters
{
    static void Main()
    {
        // Write a program that creates an array containing all letters from the alphabet (A-Z).
        // Read a word from the console and print the index of each of its letters in the array.

        Console.WriteLine("Enter a word:");
        string word = Console.ReadLine();
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if ((alphabet[j] == word[i]) && (j < 26))
                {
                    Console.WriteLine("{0} --> index {1}", word[i], (alphabet[j] - 65));
                }
                if ((alphabet[j] == word[i]) && (j >= 26))
                {
                    Console.WriteLine("{0} --> index {1}", word[i], (alphabet[j] - 97));
                }
            }
        }
    }
}

