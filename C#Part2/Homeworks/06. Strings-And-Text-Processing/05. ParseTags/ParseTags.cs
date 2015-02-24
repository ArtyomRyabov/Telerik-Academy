/* You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> 
   and </upcase> to upper-case.
    The tags cannot be nested.
   Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
   The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

namespace P05.ParseTags
{
    using System;
    using System.Text;

    class ParseTags
    {
        static void Main()
        {
            Console.WriteLine("Enter your text:");
            string text = Console.ReadLine();
            Console.WriteLine("\n" + "Result:");
            Console.WriteLine(ChangedText(text));
        }

        private static string ChangedText(string text)
        {
            StringBuilder tempText = new StringBuilder();

            while (text.Contains("</upcase>"))
            {
                tempText.Clear();

                for (int i = 0; i < text.Length; i++)
                {
                    if (i == text.IndexOf("<upcase>"))
                    {
                        i += 8;

                        while (i != text.IndexOf("</upcase>"))
                        {
                            tempText.Append(text[i].ToString().ToUpper());
                            i++;
                        }

                        i += 8;
                    }
                    else if (i == text.LastIndexOf("<upcase>"))
                    {
                        i += 8;

                        while (i != text.LastIndexOf("</upcase>"))
                        {
                            tempText.Append(text[i].ToString().ToUpper());
                            i++;
                        }

                        i += 8;
                    }
                    else
                    {
                        tempText.Append(text[i]);
                    }
                }

                text = tempText.ToString();
            }
            
            return tempText.ToString();
        }
    }
}