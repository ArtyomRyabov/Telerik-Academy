using System;
using System.Numerics;
using System.Text;

class SaddyKopper
{
    static void Main()
    {
        StringBuilder number = new StringBuilder();
        number.Append(Console.ReadLine());

        number.Remove((number.Length - 1), 1);
        long sum = 0;
        BigInteger product = 1;
        byte transitions = 0;

        while (true)
        {
            while (number.Length != 0)
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        sum += number[i] - '0';
                    }
                }

                product *= sum;
                sum = 0;
                number.Remove((number.Length - 1), 1);
            }

            number.Append(product);
            product = 1;
            transitions++;

            if (number.Length == 1)
            {
                Console.WriteLine(transitions);
                Console.WriteLine(number);
                return;
            }
            else if (transitions < 10)
            {
                number.Remove((number.Length - 1), 1);
            }
            else if (transitions == 10)
            {
                Console.WriteLine(number);
                return;
            }
        }
    }
}
