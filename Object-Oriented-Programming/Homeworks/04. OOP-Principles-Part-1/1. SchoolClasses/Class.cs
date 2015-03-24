namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Class : IComment
    {
        private string classID;
        private string comment;
        private List<Student> studentsList;
        private List<Teacher> teachersList;

        public Class(string classID, List<Teacher> teachers, List<Student> students, string comment)
            : this (classID, teachers, students)
        {
            this.Comment = comment;
        }

        public Class(string classID, List<Teacher> teachers, List<Student> students)
        {
            this.ClassID = classID;
            this.StudentsList = students;
            this.TeachersList = teachers;
        }

        public string ClassID
        {
            get
            {
                return this.classID;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid class name!");
                }

                this.classID = value;
            }
        }

        public List<Student> StudentsList
        {
            get
            {
                return new List<Student>(this.studentsList);
            }
            private set
            {
                this.studentsList = value;
            }
        }

        public List<Teacher> TeachersList
        {
            get
            {
                return new List<Teacher>(this.teachersList);
            }
            private set
            {
                this.teachersList = value;
            }
        }

        public string Comment
        {
            get
            {
                if (string.IsNullOrEmpty(this.comment))
                {
                    return "No comment about this class";
                }

                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        public override string ToString()
        {
            return string.Format("\"{0}\"\n*{1}*\n\nTeachers:\n{2}\n\nStudents:\n{3}", this.ClassID,
                                 this.Comment, string.Join("\n", this.teachersList), string.Join("\n", this.studentsList));
        }
    }
}
