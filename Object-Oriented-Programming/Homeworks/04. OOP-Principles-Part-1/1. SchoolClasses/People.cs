namespace SchoolClasses
{
    using System;

    public abstract class People : IComment
    {
        private string fullName;
        private string comment;

        protected People(string name)
        {
            this.FullName = name;
            this.Comment = comment;
        }

        public string FullName
        {
            get
            {
                return this.fullName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }

                this.fullName = value;
            }
        }

        public string Comment
        {
            get
            {
                if (string.IsNullOrEmpty(this.comment))
                {
                    return "No comment about this person";
                }

                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
