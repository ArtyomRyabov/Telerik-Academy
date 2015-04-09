namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private const byte MinCategoryNameLength = 2;
        private const byte MaxCategoryNameLength = 15;
        private const string CategoryName = "Category name";
        private const string ProductToAdd = "Product to add";
        private const string ProductToRemove = "Product to remove";

        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, CategoryName));
                Validator.CheckIfStringLengthIsValid(value, MaxCategoryNameLength, MinCategoryNameLength,
                    string.Format(GlobalErrorMessages.InvalidStringLength, CategoryName, MinCategoryNameLength, MaxCategoryNameLength));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct product)
        {
            Validator.CheckIfNull(product, string.Format(GlobalErrorMessages.ObjectCannotBeNull, ProductToAdd));

            this.products.Add(product);
        }

        public void RemoveCosmetics(IProduct product)
        {
            Validator.CheckIfNull(product, string.Format(GlobalErrorMessages.ObjectCannotBeNull, ProductToRemove));

            if (!this.products.Contains(product))
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", product.Name, this.Name)); 
            }

            this.products.Remove(product);
        }

        public string Print()
        {
            var sortedProducts = this.products.OrderBy(p => p.Brand).ThenByDescending(p => p.Price);

            StringBuilder output = new StringBuilder();

            output.AppendLine(string.Format("{0} category - {1} {2} in total", 
                this.Name, this.products.Count, this.products.Count == 1 ? "product" : "products"));

            foreach (var product in sortedProducts)
            {
                output.AppendLine(product.Print());
            }

            return output.ToString().Trim();
        }
    }
}
