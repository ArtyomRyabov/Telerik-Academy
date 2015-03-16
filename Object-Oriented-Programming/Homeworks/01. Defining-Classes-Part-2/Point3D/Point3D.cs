namespace Point3D
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D startPoint = new Point3D(0, 0, 0);     // Problem 2

        public Point3D(double x, double y, double z)      // Problem 1
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartPoint                  // Problem 2
        {
            get
            {
                return startPoint;
            }
        }

        public double X { get; private set; }             // Problem 1
        public double Y { get; private set; }             // Problem 1
        public double Z { get; private set; }             // Problem 1

        public override string ToString()                 // Problem 1
        {
            return String.Format("{0}, {1}, {2}", this.X, this.Y, this.Z);
        }
    }
}
