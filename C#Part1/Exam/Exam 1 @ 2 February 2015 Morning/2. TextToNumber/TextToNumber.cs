using System;

class TextToNumber
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        string text = Console.ReadLine();

        long result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '@')
            {
                Console.WriteLine(result);
                return;
            }
            else if (Char.IsDigit(text[i]))
            {
                result *= (text[i] - 48);
            }
            else if (Char.IsLetter(text[i]) && text[i] < 91)
            {
                result += (text[i] - 65);
            }
            else if (Char.IsLetter(text[i]) && text[i] > 96)
            {
                result += (text[i] - 97);
            }
            else
            {
                result %= M;
            }
        }
    }
}