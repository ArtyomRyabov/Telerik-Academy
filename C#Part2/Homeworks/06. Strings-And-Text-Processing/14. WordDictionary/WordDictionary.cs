// A dictionary is stored as a sequence of text lines containing words and their explanations.
// Write a program that enters a word and translates it by using the dictionary.

namespace P14.WordDictionary
{
    using System;
    using System.Collections.Generic;

    class WordDictionary
    {
        static void Main()
        {
            Dictionary<string, string> cSharpDictionary = new Dictionary<string, string>
            {
                {".net", "platform for applications from Microsoft"},
                {"clr", "managed execution environment for .NET"},
                {"namespace", "hierarchical organization of classes"}
            };

            Console.Title = "C# DICTIONARY";
            Console.WriteLine(new string('=', 37));
            Console.WriteLine("ENTER A WORD TO CHECK FOR ITS MEANING");
            Console.WriteLine(new string('-', 37));
            string checkWord = Console.ReadLine().ToLower();


            if (cSharpDictionary.ContainsKey(checkWord))
            {
                Console.Clear();
                Console.WriteLine(new string('=', 79));
                Console.WriteLine("{0} <==> {1}", checkWord.ToUpper(), cSharpDictionary[checkWord].ToUpper());
                Console.WriteLine(new string('=', 79));
            }
            else
            {
                Console.WriteLine(new string('-', 37));
                Console.WriteLine("SORRY! NO INFORMATION ABOUT \"{0}\".", checkWord.ToUpper());
                Console.WriteLine(new string('=', 37));
            }
        }
    }
}
