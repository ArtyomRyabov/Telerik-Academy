namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string phoneNumber;
        private string email;
        private int groupNumber;
        private List<int> marks;

        public Student(string firstName, string lastName, string facultyNumber, string phoneNumber, string email, int groupNumber, List<int> marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.Marks = marks;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Any(x => !char.IsLetter(x)))
                {
                    throw new ArgumentNullException("Non-existing name");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Any(x => !char.IsLetter(x)))
                {
                    throw new ArgumentNullException("Non-existing name");
                }

                this.lastName = value;
            }
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Any(x => !char.IsDigit(x)))
                {
                    throw new ArgumentNullException("Non-existing faculty number");
                }

                this.facultyNumber = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Non-existing phone number");
                }

                this.phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Non-existing e-mail");
                }

                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            private set
            {
                this.marks = value;
            }
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

        public override string ToString()
        {
            return string.Format("{0} {1}, FN:{2}, Gr:{3}, Marks:{4} / {5} / {6}", this.FirstName, this.LastName, this.facultyNumber, 
                                 this.groupNumber, string.Join(",", this.marks), this.phoneNumber, this.email);
        }
    }
}
