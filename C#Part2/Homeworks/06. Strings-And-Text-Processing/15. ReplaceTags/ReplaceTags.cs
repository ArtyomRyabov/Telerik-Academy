// Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with 
// corresponding tags [URL=…]…[/URL].

namespace P15.ReplaceTags
{
    using System;

    class ReplaceTags
    {
        static void Main()
        {
            Console.WriteLine("Enter the text:");
            string input = Console.ReadLine();

            input = input.Replace((@"<a href="""), "[URL=");
            input = input.Replace(@""">", "]");
            input = input.Replace("</a>", "[/URL]");

            Console.WriteLine("\n" + "Text with replaced tags:");
            Console.WriteLine(input);
        }
    }
}
