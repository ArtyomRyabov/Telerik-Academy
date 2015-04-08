namespace Cosmetics.Products
{
    using System.Collections.Generic;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IProduct, IToothpaste
    {
        private const byte MinIngredientNameLength = 4;
        private const byte MaxIngredientNameLength = 12;
        private const string EachIngredient = "Each ingredient";

        private IEnumerable<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IEnumerable<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get 
            {
                foreach (var ingredient in this.ingredients)
                {
                    Validator.CheckIfStringLengthIsValid(ingredient, MaxIngredientNameLength, MinIngredientNameLength,
                        string.Format(GlobalErrorMessages.InvalidStringLength, EachIngredient, MinIngredientNameLength, MaxIngredientNameLength));
                    Validator.CheckIfStringIsNullOrEmpty(ingredient, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, EachIngredient));
                }
                
                return string.Join(", ", this.ingredients); 
            }
        }

        public override string Print()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(base.Print());
            output.Append(string.Format("  * Ingredients: {0}", this.Ingredients));

            return output.ToString();
        }
    }
}
