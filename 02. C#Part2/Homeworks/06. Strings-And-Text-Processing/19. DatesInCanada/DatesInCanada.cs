// Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
// Display them in the standard date format for Canada.

namespace P19.DatesInCanada
{
    using System;
    using System.Globalization;
    using System.Threading;

    class DatesInCanada
    {
        static void Main()
        {
            string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school." +
                          " The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9)";
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            CanadaDateFoemat(TrimWords(words));
        }

        private static void CanadaDateFoemat(string[] words)
        {
            foreach (string word in words)
            {
                DateTime newDateTime = new DateTime();

                if (DateTime.TryParseExact(word, "d.M.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out newDateTime))
                {
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                    Console.WriteLine(newDateTime.Date.ToShortDateString());
                }
            }
        }

        private static string[] TrimWords(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].TrimStart('.');
                words[i] = words[i].TrimEnd('.');
            }

            return words;
        }
    }
}