namespace Students
{
    using System;

    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int number, string name)
        {
            this.GroupNumber = number;
            this.DepartmentName = name;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentNullException("Non-existing group number");
                }

                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Non-existing department name");
                }

                this.departmentName = value;
            }
        }
    }
}
