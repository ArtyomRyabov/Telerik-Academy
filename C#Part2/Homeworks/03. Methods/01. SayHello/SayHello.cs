// Write a method that asks the user for his name and prints “Hello, <name>”
// Write a program to test this method.

using System;

class SayHello
{
    static void Main()
    {
        Greeting();
    }

    static void Greeting()
    {
        Console.Write("What is your name: ");
        string name = Console.ReadLine();
        bool isCorrectName = CorrectName(name);

        if (isCorrectName)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        else
        {
            Console.WriteLine("This is not your name!");
        }
    }

    static bool CorrectName(string name)
    {
        foreach (char item in name)
        {
            if ((((int)item > 90 && (int)item < 97)) || ((int)item > 120 || ((int)item < 65) && (item != 32)))
            {
                return false;
            }
        }
        return true;
    }

}

