namespace SchoolClasses
{
    using System;

    public class Student : People
    {
        private int classID;

        public Student(string name, int classID)
            : base (name)
        {
            this.ClassID = classID;
        }

        public Student(string name, int classID, string comment)
            : this (name, classID)
        {
            this.Comment = comment;
        }

        public int ClassID
        {
            get
            {
                return this.classID;
            }
            private set
            {
                if (value < 1)
                {
                    throw new IndexOutOfRangeException("ID must be bigger than zero!");
                }

                this.classID = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Class ID: {1}\n *{2}*", this.FullName, this.ClassID, this.Comment);
        }
    }
}
