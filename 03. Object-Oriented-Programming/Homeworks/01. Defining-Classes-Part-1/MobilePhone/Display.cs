namespace MobilePhone
{
    using System;

    public class Display
    {
        private double? size;     // Problem 1
        private int? colours;

        public Display()          // Problem 2
            : this(null)
        {
        }

        public Display(double? size)
            : this(size, null)
        {
        }

        public Display(double? size, int? colours)
        {
            this.Size = size;
            this.Colours = colours;
        }

        public double? Size                            // Problem 5
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid size!");
                }

                this.size = value;
            }
        }

        public int? Colours
        {
            get
            {
                return this.colours;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid number of colours!");
                }

                this.colours = value;
            }
        }
    }
}
