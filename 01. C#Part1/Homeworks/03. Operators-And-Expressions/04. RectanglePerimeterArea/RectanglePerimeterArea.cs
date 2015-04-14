using System;

class RectanglePerimeterArea
{
    static void Main()
    {
        // Write an expression that calculates rectangle’s perimeter and area by given width and height.

        Console.Write("Enter rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter rectangle's height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = (width + height) * 2;
        double area = width * height;
        Console.WriteLine("Rectangle's perimeter: {0}\nRectangle's area: {1}", perimeter, area);
    }
}

