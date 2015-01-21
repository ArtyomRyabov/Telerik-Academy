using System;

class PointCircleRectangle
{
    static void Main()
    {
        // Write an expression that checks for given point (x, y) if it is within the circle 
        // K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

        Console.WriteLine("Enter (x, y) coordinates of a point:");
        Console.Write("x = ");
        double xPoint = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double yPoint = double.Parse(Console.ReadLine());
        int xCircle = 1;
        int yCircle = 1;
        double radius = 1.5;
        bool inCircle = Math.Pow((xPoint - xCircle), 2) + Math.Pow((yPoint - yCircle), 2) <= Math.Pow(radius, 2);
        Console.WriteLine("The point is within the circle: {0}", inCircle);

        int topRectangle = 1;
        int bottomRectangle = -1;
        int leftRectangle = -1;
        int rightRectangle = 5;
        bool outRectangle = ((xPoint < leftRectangle) || (xPoint > rightRectangle)) ||
                            ((yPoint > topRectangle) || (yPoint < bottomRectangle));
        Console.WriteLine("The point is out of the rectangle: {0}", outRectangle);
        Console.WriteLine("The point is within the circle and out of the rectangle: {0}", (inCircle && outRectangle));
    }
}

