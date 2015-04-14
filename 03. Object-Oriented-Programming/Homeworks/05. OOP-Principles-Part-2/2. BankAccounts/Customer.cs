namespace BankAccounts
{
    using System;

    public abstract class Customer
    {
        private string name;

        protected Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            { 
                return this.name; 
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid customer name!");
                }

                this.name = value;
            }
        }
    }
}
