namespace Shapes
{
    using System;

    public class Square : Shape
    {
        public Square(double width)
            : base(width, width)
        {
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Width;
        }

        public override string ToString()
        {
            return string.Format("{0} (side = {1}), surface = {2:F2}", this.GetType().Name, this.Width, this.CalculateSurface());
        }
    }
}
