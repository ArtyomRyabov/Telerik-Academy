namespace P1.EnigmaCat
{
    using System;
    using System.Text;

    class EnigmaCat
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            ulong toDecimal = 0;
            StringBuilder result = new StringBuilder();

            foreach (string word in input)
            {
                //Convert to decimal numeral system:
                ulong multiplier = 1;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    ulong baseNumber = 17;
                    toDecimal += (ulong)(word[i] - 'a') * multiplier;
                    multiplier *= baseNumber;
                }

                //Convert to 26 numeral system and decode:
                while (toDecimal > 0)
                {
                    ulong baseNumber = 26;
                    byte remainder = (byte)(toDecimal % baseNumber);
                    toDecimal /= baseNumber;
                    result.Insert(0, (char)(remainder + 'a'));
                }

                Console.Write("{0} ", result );
                result.Clear();
            }

            Console.WriteLine();
        }
    }
}
