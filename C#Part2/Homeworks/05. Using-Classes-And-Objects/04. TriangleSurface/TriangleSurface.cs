/*  Write methods that calculate the surface of a triangle by given:
        Side and an altitude to it;
        Three sides;
        Two sides and an angle between them;
    Use System.Math.
 */

using System;

class TriangleSurface
{
    static void Main()
    {
        Menu();
    }

    private static void Menu()
    {
        Console.WriteLine(new string('=', 52));
        Console.Write(new string(' ', 3));
        Console.WriteLine("CALCULATE THE SURFACE OF A TRIANGLE BY GIVEN:");
        Console.WriteLine(new string('-', 52));
        Console.WriteLine("1. SIDE AND AN ALTITUDE TO IT");
        Console.WriteLine("2. THREE SIDES");
        Console.WriteLine("3. TWO SIDES AND AN ANGLE BETWEEN THEM");
        Console.WriteLine(new string('-', 52));
        Console.WriteLine("Press 1 / 2 / 3 for choise or any other key to exit");
        Console.WriteLine("followed by <return>");
        Console.WriteLine(new string('=', 52));

        char key = char.Parse(Console.ReadLine());
        Console.Clear();

        switch (key)
        {
            case '1':
                SideAndAnAltitudeToIt();
                break;
            case '2':
                ThreeSides();
                break;
            case '3':
                TwoSidesAndAnAngleBetweenThem();
                break;
            default: Exit(); break;
        }
    }

    private static void Exit()
    {
        Console.WriteLine(new string('=', 32));
        Console.WriteLine("Thank you for using the program!");
        Console.WriteLine(new string('-', 32));
        Console.Write(new string(' ', 4));
        Console.WriteLine("Press <return> to exit!");
        Console.WriteLine(new string('=', 32));
        Environment.Exit(0);
    }

    private static void TwoSidesAndAnAngleBetweenThem()
    {
        decimal a = 0;
        decimal b = 0;
        decimal angle = 0;
        Console.WriteLine(new string('=', 39));
        Console.WriteLine("Enter values for two sides and an angle");
        Console.WriteLine(new string('-', 39));
        Console.Write("a = ");
        a = decimal.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = decimal.Parse(Console.ReadLine());
        Console.Write("angle = ");
        angle = decimal.Parse(Console.ReadLine());

        if ((a <= 0) || (b <= 0) || (angle <= 0) || (angle >= 180))
        {
            Console.WriteLine(new string('-', 39));
            Console.WriteLine("Invalid values!");
            TwoSidesAndAnAngleBetweenThem();
        }

        angle = angle * (decimal)Math.PI / 180;
        decimal area = (a * b * (decimal)Math.Sin((double)angle)) / 2;
        Console.WriteLine(new string('-', 39));
        Console.WriteLine("Result: {0:F2}", area);

        Console.WriteLine(new string('=', 39));
        Console.WriteLine("Press 1 to start a new task or other");
        Console.WriteLine("key for Menu followed by <return>");
        Console.WriteLine(new string('-', 39));

        char key = char.Parse(Console.ReadLine());
        Console.Clear();

        if (key == '1')
        {
            TwoSidesAndAnAngleBetweenThem();
        }
        else
        {
            Menu();
        }
    }

    private static void ThreeSides()
    {
        decimal a = 0;
        decimal b = 0;
        decimal c = 0;
        Console.WriteLine(new string('=', 43));
        Console.WriteLine("Enter numbers for the three sides");
        Console.WriteLine(new string('-', 43));
        Console.Write("a = ");
        a = decimal.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = decimal.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = decimal.Parse(Console.ReadLine());

        if ((a <= 0) || (b <= 0) || (c <= 0) || (a + b < c) || (a + c < b) || (b + c < a))
        {
            Console.WriteLine(new string('-', 43));
            Console.WriteLine("These numbers are not a triangle's numbers!");
            ThreeSides();
        }

        decimal p = (a + b + c) / 2;
        decimal area = (decimal)Math.Sqrt((double)(p * (p - a) * (p - b) * (p - c)));
        Console.WriteLine(new string('-', 43));
        Console.WriteLine("Result: {0:F2}", area);

        Console.WriteLine(new string('=', 43));
        Console.WriteLine("Press 1 to start a new task or other key ");
        Console.WriteLine("for Menu followed by <enter>");
        Console.WriteLine(new string('-', 43));

        char key = char.Parse(Console.ReadLine());
        Console.Clear();

        if (key == '1')
        {
            ThreeSides();
        }
        else
        {
            Menu();
        }
    }

    private static void SideAndAnAltitudeToIt()
    {
        decimal side = 0;
        decimal altitude = 0;
        Console.WriteLine(new string('=', 40));
        Console.WriteLine("Enter number for side and altitude to it");
        Console.WriteLine(new string('-', 40));
        Console.Write("side = ");
        side = decimal.Parse(Console.ReadLine());
        Console.Write("altitude = ");
        altitude = decimal.Parse(Console.ReadLine());

        if ((side <= 0) || (altitude <= 0))
        {
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Invalid numbers!");
            SideAndAnAltitudeToIt();
        }

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Result: {0:F2}", (side * altitude) / 2);
        Console.WriteLine(new string('=', 40));

        Console.WriteLine("Press 1 to start a new task or other");
        Console.WriteLine("key for Menu followed by <return>");
        Console.WriteLine(new string('-', 40));

        char key = char.Parse(Console.ReadLine());
        Console.Clear();

        if (key == '1')
        {
            SideAndAnAltitudeToIt();
        }
        else
        {
            Menu();
        }
    }
}

