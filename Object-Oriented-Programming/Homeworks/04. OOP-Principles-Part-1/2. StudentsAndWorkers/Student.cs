namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Grade can not be less than 1 and more than 6");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Grade: {1}", base.ToString(), this.Grade);
        }
    }
}
