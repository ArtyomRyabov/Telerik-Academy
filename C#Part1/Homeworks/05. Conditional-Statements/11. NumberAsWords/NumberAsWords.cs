using System;

class NumberAsWords
{
    static void Main()
    {
        // Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

        Console.Write("Enter a number in the range [0…999]: ");
        int number = int.Parse(Console.ReadLine());

        int hundreds = number / 100;
        int tenths = (number % 100) / 10;
        int units = number % 10;

        if (number < 0 || number > 999)
        {
            Console.WriteLine("Invalid number!");
            return;
        }
        if (number == 0)
        {
            Console.WriteLine("Zero");
            return;
        }
        if (hundreds > 0 && hundreds <= 9)
        {
            switch (hundreds)
            {
                case 1:
                    Console.Write("One hundred ");
                    break;
                case 2:
                    Console.Write("Two hundred ");
                    break;
                case 3:
                    Console.Write("Three hundred ");
                    break;
                case 4:
                    Console.Write("Four hundred ");
                    break;
                case 5:
                    Console.Write("Five hundred ");
                    break;
                case 6:
                    Console.Write("Six hundred ");
                    break;
                case 7:
                    Console.Write("Seven hundred ");
                    break;
                case 8:
                    Console.Write("Eight hundred ");
                    break;
                case 9:
                    Console.Write("Nine hundred ");
                    break;
                default:
                    Console.WriteLine("Invalid!");
                    break;
            }
            if (tenths == 0 && units == 0)
            {
                Console.WriteLine();
                return;
            }
            else 
            {
                Console.Write("and ");
            }
        }
        if (tenths > 1)
        {
            switch (tenths)
            {
                case 2:
                    Console.Write("twenty ");
                    break;
                case 3:
                    Console.Write("thirty ");
                    break;
                case 4:
                    Console.Write("fourty ");
                    break;
                case 5:
                    Console.Write("fifty ");
                    break;
                case 6:
                    Console.Write("sixty ");
                    break;
                case 7:
                    Console.Write("seventy ");
                    break;
                case 8:
                    Console.Write("eighty ");
                    break;
                case 9:
                    Console.Write("ninety ");
                    break;
                default:
                    Console.WriteLine("Invalid!");
                    break;
            }
        }
        if (tenths == 1)
        {
            switch (units)
            {
                case 0:
                    Console.WriteLine("ten");
                    break;
                case 1:
                    Console.WriteLine("eleven");
                    break;
                case 2:
                    Console.WriteLine("twelve");
                    break;
                case 3:
                    Console.WriteLine("thirteen");
                    break;
                case 4:
                    Console.WriteLine("fourteen");
                    break;
                case 5:
                    Console.WriteLine("fifteen");
                    break;
                case 6:
                    Console.WriteLine("sixteen");
                    break;
                case 7:
                    Console.WriteLine("seventeen");
                    break;
                case 8:
                    Console.WriteLine("eighteen");
                    break;
                case 9:
                    Console.WriteLine("nineteen");
                    break;
                default:
                    Console.WriteLine("Invalid!");
                    break;
            }
        }
        if (tenths != 1)
        {
            switch (units)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}

