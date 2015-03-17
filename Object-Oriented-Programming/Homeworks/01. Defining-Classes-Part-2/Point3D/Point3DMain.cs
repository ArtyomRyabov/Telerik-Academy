namespace Point3D
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Point3DMain
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Start point coordinates: ({0})\n", Point3D.StartPoint);

            Point3D secondPoint = new Point3D(50.05, 50, 5.555);
            Console.WriteLine("Second point coordinates: ({0})\n", secondPoint);
            Console.WriteLine("The distance between start and second point: {0:F2}\n",
                DistanceCalculator.CalculateDistance(secondPoint, Point3D.StartPoint));

            Path path = new Path();
            path.AddPath(Point3D.StartPoint);          // Adding paths
            path.AddPath(secondPoint);
            path.AddPath(new Point3D(-2, 22, 0.22));
            Console.WriteLine(path);

            Console.WriteLine("Writing the upper coordinates to 'test.txt' file\n");
            PathStorage.SavePath(path, @"..\..\test.txt");   

            Console.WriteLine("Read 'test.txt' file:");               
            Path testRead = PathStorage.LoadPath(@"..\..\test.txt");
            Console.WriteLine(testRead);     
        }
    }
}
