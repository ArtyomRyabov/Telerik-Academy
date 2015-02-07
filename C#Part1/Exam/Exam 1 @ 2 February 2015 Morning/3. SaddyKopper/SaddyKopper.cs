using System;
using System.Numerics;

class SaddyKopper
{
    static void Main()
    {
        string number = Console.ReadLine();
        string currentNumber = "";
        long sum = 0;
        BigInteger product = 1;
        int transformation = 0;
        bool isTrue = number.Length > 0;

        while (isTrue)
        {
            for (int i = 0; i < number.Length - 1; i++)
            {
                currentNumber += string.Join("", number[i] - 48);
            }
            number = currentNumber;
            currentNumber = "";

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
                    number = Convert.ToString(product);
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
                currentNumber += string.Join("", number[i] - 48);
            }
            product *= sum;
            sum = 0;
            number = currentNumber;
            currentNumber = "";
        }
        Console.WriteLine(transformation);
        Console.WriteLine(product);
    }
}