using System;

class AgeCalculation
{
    static void Main()
    {
        // Write a program to read your birthday from the console and print how 
        // old you are now and how old you will be after 10 years.

        Console.WriteLine("Enter your birthday (DD/MM/YY):");
        DateTime birthday = DateTime.Parse(Console.ReadLine());
        DateTime now = DateTime.Now;
        int age;

        if (now.DayOfYear >= birthday.DayOfYear)
        {
            age = now.Year - birthday.Year;
        }
        else
        {
            age = (now.Year - birthday.Year) - 1;

        }
        Console.WriteLine("Your current age is: {0}", age);
        Console.WriteLine("In ten years you will be {0} years old", age + 10);
    }
}

