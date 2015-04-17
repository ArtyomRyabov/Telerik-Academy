namespace Point3D
{
    using System;

    public static class DistanceCalculator
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double deltaX = secondPoint.X - firstPoint.X;
            double deltaY = secondPoint.Y - firstPoint.Y;
            double deltaZ = secondPoint.Z - firstPoint.Z;

            return Math.Sqrt(deltaX * deltaX  + deltaY * deltaY + deltaZ * deltaZ); 
        }
    }
}