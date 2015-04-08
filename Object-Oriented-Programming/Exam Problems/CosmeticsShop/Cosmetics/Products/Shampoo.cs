namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Shampoo : Product, IProduct, IShampoo
    {
        private const string UsageType = "Usage type";

        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
            this.Price *= this.Milliliters;
        }

        public uint Milliliters
        {
            get { return this.milliliters; }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Quantity cannot be 0 or less!");
                }

                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get { return this.usage; }

            private set
            {
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, UsageType));

                this.usage = value;
            }
        }

        public override string Print()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(base.Print());
            output.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            output.Append(string.Format("  * Usage: {0}", this.Usage));

            return output.ToString();
        }
    }
}
