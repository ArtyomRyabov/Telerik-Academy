namespace SchoolClasses
{
    using System;

    public class Discipline : IComment
    {
        private string name;
        private string comment;
        private byte numberOfLectures;
        private byte numberOfExercises;

        public Discipline(string name, byte numberOfLectures, byte numberOfExercises)
        {
            this.Name = name;
            this.Comment = comment;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public Discipline(string name, byte numberOfLectures, byte numberOfExercises, string comment)
            : this(name, numberOfLectures, numberOfExercises)
        {
            this.Comment = comment;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid name!");
                }

                this.name = value;
            }
        }

        public byte NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number!");
                }
                this.numberOfLectures = value;
            }
        }

        public byte NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid number!");
                }
                this.numberOfExercises = value;
            }
        }

        public string Comment
        {
            get
            {
                if (string.IsNullOrEmpty(this.comment))
                {
                    return "No comment about this discipline";
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
            return string.Format("\"{0}\"\nNumber of lectures: {1}\nNumber of exercises: {2}\n*{3}*", this.Name,
                                 this.NumberOfLectures, this.NumberOfExercises, this.Comment);
        }
    }
}
