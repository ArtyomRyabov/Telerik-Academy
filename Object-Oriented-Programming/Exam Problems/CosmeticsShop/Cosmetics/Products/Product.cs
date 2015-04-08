namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
    {
        private const byte MinProductNameLength = 3;
        private const byte MaxProductNameAndBrandLength = 10;
        private const byte MinProductBrandLength = 2;
        private const string ProductName = "Product name";
        private const string ProductBrand = "Product brand";
        private const string Genger = "Gender";

        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, ProductName));
                Validator.CheckIfStringLengthIsValid(value, MaxProductNameAndBrandLength, MinProductNameLength,
                    string.Format(GlobalErrorMessages.InvalidStringLength, ProductName, MinProductNameLength, MaxProductNameAndBrandLength));

                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, ProductBrand));
                Validator.CheckIfStringLengthIsValid(value, MaxProductNameAndBrandLength, MinProductBrandLength,
                    string.Format(GlobalErrorMessages.InvalidStringLength, ProductBrand, MinProductBrandLength, MaxProductNameAndBrandLength));

                this.brand = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }

            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be 0 or less!");
                }

                this.price = value;
            }
        }

        public GenderType Gender
        {
            get { return this.gender; }

            private set
            {
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, Gender));

                this.gender = value;
            }
        }

        public virtual string Print()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            output.AppendLine(string.Format("  * Price: ${0}", this.Price));
            output.Append(string.Format("  * For gender: {0}", this.Gender));

            return output.ToString();
        }
    }
}
