namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private const int numberOfWorkDays = 5;

        private double weekSalary;
        private double workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be more than 0");
                }

                this.weekSalary = value;
            }
        }

        public double WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Value must be more than 0");
                }

                this.workHoursPerDay = value;
            }
        }
        
        public decimal MoneyPerHour()
        {
            decimal result = ((decimal)this.WeekSalary / numberOfWorkDays) / (decimal)(this.WorkHoursPerDay);

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}, Money per hour: {1:F2}", base.ToString(), this.MoneyPerHour());
        }
    }
}
