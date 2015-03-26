namespace Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
        
        public double Width
        {
            get 
            { 
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be bigger than 0");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            { 
                return this.height; 
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be bigger than 0");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            return string.Format("{0} (width = {1}, height = {2}), surface = {3:F2}", this.GetType().Name, this.Width,
                                  this.Height, this.CalculateSurface());
        }
    }
}
