namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string schoolName;
        private List<Class> schoolClassesList;

        public School(string name)
        {
            this.Name = name;
            this.schoolClassesList = new List<Class>();
        }

        public string Name
        {
            get
            {
                return this.schoolName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }

                this.schoolName = value;
            }
        }

        public List<Class> SchoolClassesList
        {
            get
            {
                return new List<Class>(this.schoolClassesList);
            }
            private set
            {
                this.schoolClassesList = value;
            }
        }
    }
}
