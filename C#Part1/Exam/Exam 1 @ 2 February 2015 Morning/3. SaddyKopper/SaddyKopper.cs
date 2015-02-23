using System;
using System.Numerics;
using System.Text;

class SaddyKopper
{
    static void Main()
    {
        StringBuilder number = new StringBuilder();
        number.Append(Console.ReadLine());
        StringBuilder currentNumber = new StringBuilder();
        long sum = 0;
        BigInteger product = 1;
        int transformation = 0;
        bool isTrue = number.Length > 0;

        while (isTrue)
        {
            number.Remove((number.Length - 1), 1);

            if (number.Length == 0)
            {
                transformation++;
                if (transformation >= 10)
                {
                    Console.WriteLine(product);
                    return;
                }
                if (product < 10)
                {
                    break;
                }
                else
                {
                    number.Append(product);
                    product = 1;
                    continue;
                }
            }

            for (int i = 0; i < number.Length; i++)
            {
                if (i % 2 == 0)
                {
                    sum += number[i] - 48;
                }

                char ch = Convert.ToChar(number[i] - 48);
                currentNumber.Append((int)ch);
            }

            product *= sum;
            sum = 0;
            number.Clear();
            number.Append(currentNumber);
            currentNumber.Clear();
        }

        Console.WriteLine(transformation);
        Console.WriteLine(product);
    }
}