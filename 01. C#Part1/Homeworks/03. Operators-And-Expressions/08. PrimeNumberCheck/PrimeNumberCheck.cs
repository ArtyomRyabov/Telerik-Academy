using System;

class PrimeNumberCheck
{
    static void Main()
    {
        // Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is 
        // divisible without remainder only to itself and 1).

        Console.Write("Enter positive integer number n (n <= 100): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("This integer is prime: ");
        bool oddNumber = true;

        if ((n >= 0) && (n <= 100))
        {
            if (n >= 2)
            {
                for (int i = 2; i <= n; i++)
                {
                    if ((n % i == 0) && (n != i))
                    {
                        oddNumber = false;
                    }
                }
                Console.WriteLine(oddNumber);
            }
            else if (n < 2)
            {
                Console.WriteLine(!oddNumber);
            }
        }
        else
        {
            Console.WriteLine("Number out of range!");
        }
    }
}

