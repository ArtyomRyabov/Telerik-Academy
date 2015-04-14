using System;

class CirclePerimeterArea
{
    static void Main()
    {
        // Write a program that reads the radius r of a circle and prints its perimeter and area 
        // formatted with 2 digits after the decimal point.

        Console.Write("Enter radius of a circle: ");
        double r = double.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * r;
        double area = Math.PI * Math.Pow(r, 2);

        Console.WriteLine("Circle's perimeter is: {0:F2}\nCircle's area is: {1:F2}",
                            perimeter, area);
    }
}

