using System;

class ComparingFloats
{
    static void Main()
    {
        // Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
        // Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the 
        // nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are 
        // more closely to each other than a fixed constant eps.

        Console.Write("Enter the first floating-point number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second floating-point number: ");
        double b = Convert.ToDouble(Console.ReadLine());
        double difference = Math.Abs(a - b);
        double eps = 0.000001;

        bool areEqual = difference < eps;
        Console.WriteLine(areEqual ? "The numbers are equal." :
            "The numbers are not equal.");
    }
}

