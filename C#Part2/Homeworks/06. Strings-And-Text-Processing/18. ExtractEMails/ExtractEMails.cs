// Write a program for extracting all email addresses from given text.
// All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace P18.ExtractEMails
{
    using System;
    using System.Linq;

    class ExtractEMails
    {
        static readonly char[] splitChars = new char[] { ' ', '#', '$', '%', '^', '`', '~', '&', '*', '(', ')', '-',
                                                         '+', '=', '\\', '|', ';', ':', '\'', '"', '<', '>', '?', '/',
                                                         '*', '+', ',', '{', '}', '[', ']', };
        static readonly char[] charsToTrim = { '@', '_', '.' };

        static void Main()
        {
            string text = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. " +
                          "This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
            string[] words = text.Split(splitChars, StringSplitOptions.RemoveEmptyEntries);

            ExtractAddresses(words);
        }

        private static void ExtractAddresses(string[] words)
        {
            foreach (string word in words)
            {
                string trimmedStart = word.TrimStart(charsToTrim);
                string trimmedEnd = trimmedStart.TrimEnd(charsToTrim);

                if (trimmedEnd.Contains('.') && trimmedEnd.Contains('@') && (trimmedEnd.Length > 5))
                {
                    Console.WriteLine(trimmedEnd); 
                }
            }
        }
    }
}
