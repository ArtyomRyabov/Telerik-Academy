namespace Shapes
{
    using System;

    public class Square : Shape
    {
        private double width;

        public Square(double width)
            : base(width, width)
        {
            this.Width = width;
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Width;
        }

        public override double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Side must be bigger than 0");
                }

                this.width = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} (side = {1}), surface = {2:F2}", this.GetType().Name, this.Width, this.CalculateSurface());
        }
    }
}
