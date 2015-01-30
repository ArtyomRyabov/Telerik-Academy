using System;
class HexadecimalToDecimal
{
    static void Main()
    {
        // Using loops write a program that converts a hexadecimal integer number to its decimal form.
        // The input is entered as string. The output should be a variable of type long.
        // Do not use the built-in .NET functionality.

        Console.Write("Enter a hexademical integer number: ");
        string hexNumber = Console.ReadLine();
        byte decimalResult = 0;
        long decimalNumber = 0;

        for (int i = 0; i < hexNumber.Length; i++)
        {
            switch (hexNumber[i])
            {
                case '0':                          
                    decimalResult = 0; 
                    break;
                case '1':
                    decimalResult = 1; 
                    break;
                case '2':
                    decimalResult = 2; 
                    break;
                case '3':
                    decimalResult = 3; 
                    break;
                case '4':
                    decimalResult = 4; 
                    break;
                case '5':
                    decimalResult = 5; 
                    break;
                case '6':
                    decimalResult = 6; 
                    break;
                case '7':
                    decimalResult = 7; 
                    break;
                case '8':
                    decimalResult = 8; 
                    break;
                case '9':
                    decimalResult = 9; 
                    break;
                case 'A':
                    decimalResult = 10; 
                    break;
                case 'B':
                    decimalResult = 11;
                    break;
                case 'C':
                    decimalResult = 12;
                    break;
                case 'D':
                    decimalResult = 13;
                    break;
                case 'E':
                    decimalResult = 14;
                    break;
                case 'F':
                    decimalResult = 15;
                    break;
                default: 
                    Console.WriteLine("Invalid input!");
                    return;
            }
            decimalNumber += decimalResult * (long)Math.Pow(16, ((hexNumber.Length - 1) - i));
        }
        Console.WriteLine(decimalNumber);
    }
}

