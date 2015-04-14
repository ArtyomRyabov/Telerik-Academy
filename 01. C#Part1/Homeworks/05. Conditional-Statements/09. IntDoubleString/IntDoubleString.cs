using System;

class IntDoubleString
{
    static void Main()
    {
        /* Write a program that, depending on the user’s choice, inputs an int, double or string variable.
           If the variable is int or double, the program increases it by one.
           If the variable is a string, the program appends * at the end.
           Print the result at the console. Use switch statement. 
         */

        Console.WriteLine("Choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        byte choise = byte.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1:
                Console.Write("Enter int: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", ++i);
                break;
            case 2:
                Console.Write("Enter double: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", ++d);
                break;
            case 3:
                Console.Write("Enter string: ");
                string s = Console.ReadLine();
                Console.WriteLine("Result: {0}", s + "*");
                break;
            default:
                Console.WriteLine("Invalid choise!");
                break;
        }
    }
}

