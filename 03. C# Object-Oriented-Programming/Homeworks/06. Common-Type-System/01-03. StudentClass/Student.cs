namespace StudentClass
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student(string firstName, string middleName, string lastName, string ssn, string address, string phone,
                       string email, byte course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = phone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public string SSN { get; private set; }

        public string Address { get; private set; }

        public string MobilePhone { get; private set; }

        public string Email { get; private set; }

        public byte Course { get; private set; }

        public Specialty Specialty { get; private set; }

        public University University { get; private set; }

        public Faculty Faculty { get; private set; }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !Student.Equals(first, second);
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^
                   this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (this.SSN != student.SSN)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.AppendLine(string.Format("Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            info.AppendLine(string.Format("SSN: {0}", this.SSN));
            info.AppendLine(string.Format("Address: {0}", this.Address));
            info.AppendLine(string.Format("Mobile phone: {0}", this.MobilePhone));
            info.AppendLine(string.Format("Email: {0}", this.Email));
            info.AppendLine(string.Format("University: {0}", this.University));
            info.AppendLine(string.Format(" Faculty: {0}", this.Faculty));
            info.AppendLine(string.Format(" Specialty: {0}", this.Specialty));
            info.AppendLine(string.Format(" Course: {0}", this.Course));

            return info.ToString();
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone,
                               this.Email, this.Course, this.Specialty, this.University, this.Faculty);
        }

        public int CompareTo(Student other)
        {
            string student = this.FirstName + this.MiddleName + this.LastName + this.SSN;
            string otherStudent = other.FirstName + other.MiddleName + other.LastName + other.SSN;

            return student.CompareTo(otherStudent);
        }
    }
}