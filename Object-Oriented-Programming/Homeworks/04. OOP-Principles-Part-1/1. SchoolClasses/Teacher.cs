namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People
    {
        private List<Discipline> disciplinesList;

        public Teacher(string name, List<Discipline> disciplinesList)
            : base (name)
        {
            this.DisciplinesList = disciplinesList;
        }

        public List<Discipline> DisciplinesList
        {
            get
            {
                return new List<Discipline>(this.disciplinesList);
            }
            private set
            {
                this.disciplinesList = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, Disciplines: {1}", this.FullName, string.Join("\n", this.disciplinesList));
        }
    }
}
