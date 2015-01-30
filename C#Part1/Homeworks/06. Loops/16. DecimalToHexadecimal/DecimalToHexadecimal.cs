using System;
class DecimalToHexadecimal
{
    static void Main()
    {
        // Using loops write a program that converts an integer number to its hexadecimal representation.
        // The input is entered as long. The output should be a variable of type string.
        // Do not use the built-in .NET functionality.

        Console.Write("Enter an integer number: ");
        long decimalNumber = long.Parse(Console.ReadLine());
        string hexNumber = "";
        char hexResult = new char();
        long remainder = 0;

        if (decimalNumber == 0)
        {
            Console.WriteLine(decimalNumber);
            return;
        }

        while (decimalNumber > 0)
        {
            
            remainder = decimalNumber % 16;
            switch (remainder)
            {
                case 0:
                    hexResult = '0';
                    break;
                case 1:
                    hexResult = '1';
                    break;
                case 2:
                    hexResult = '2';
                    break;
                case 3:
                    hexResult = '3';
                    break;
                case 4:
                    hexResult = '4';
                    break;
                case 5:
                    hexResult = '5';
                    break;
                case 6:
                    hexResult = '6';
                    break;
                case 7:
                    hexResult = '7';
                    break;
                case 8:
                    hexResult = '8';
                    break;
                case 9:
                    hexResult = '9';
                    break;
                case 10:
                    hexResult = 'A';
                    break;
                case 11:
                    hexResult = 'B';
                    break;
                case 12:
                    hexResult = 'C';
                    break;
                case 13:
                    hexResult = 'D';
                    break;
                case 14:
                    hexResult = 'E';
                    break;
                case 15:
                    hexResult = 'F';
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
            decimalNumber /= 16;
            hexNumber = hexResult + hexNumber;
        }
        Console.WriteLine(hexNumber);
    }
}

