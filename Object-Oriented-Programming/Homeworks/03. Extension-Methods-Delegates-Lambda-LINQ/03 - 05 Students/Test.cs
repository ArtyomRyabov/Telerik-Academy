namespace Students
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Test
    {
        // Problem 3
        private static IEnumerable<Student> FirstNameBeforeLast(Student[] studentsList)       
        {
            return from student in studentsList
                   where student.FirstName.CompareTo(student.LastName) == -1
                   select student;
        }

        // Problem 4
        private static IEnumerable<Student> AgeEighteenToTwentyFour(Student[] studentsList)   
        {
            return from student in studentsList
                   where (student.Age >= 18 && student.Age <= 24)
                   select student;
        }

        // Problem 5
        private static IEnumerable<Student> StudentsDescendingOrderWithLambda(Student[] studentsList)
        {
            return studentsList
                .OrderByDescending(st => st.FirstName)
                .ThenByDescending(st => st.LastName)
                .ToArray();
        }

        // Problem 5
        private static IEnumerable<Student> StudentsDescendingOrderWithLINQ(Student[] studentsList)
        {
            return from student in studentsList
                   orderby student.FirstName descending,
                   student.LastName descending
                   select student;
        }

        public static void Main()
        {
            Student[] studentsList = new Student[]
            {
                new Student("Peicho", "Peev", 18),
                new Student("Vihar", "Vetrev", 25),
                new Student("Peicho", "Svirchev", 20),
                new Student("Lozan", "Grozdev", 35),
                new Student("Biro", "Spirov", 22)
            };

            // Problem 3
            Console.WriteLine("Students whose first name is before its last name alphabetically:");       
            Console.WriteLine(string.Join(Environment.NewLine, FirstNameBeforeLast(studentsList)));

            // Problem 4
            Console.WriteLine("\nFirst name and last name of all students with age between 18 and 24:");  
            Console.WriteLine(string.Join(Environment.NewLine, AgeEighteenToTwentyFour(studentsList)));

            // Problem 5
            Console.WriteLine("\nStudents sorted by first and last name (descending order) using lambda:");
            Console.WriteLine(string.Join(Environment.NewLine, StudentsDescendingOrderWithLambda(studentsList)));

            Console.WriteLine("\nStudents sorted by first and last name (descending order) using LINQ:");
            Console.WriteLine(string.Join(Environment.NewLine, StudentsDescendingOrderWithLINQ(studentsList)));
            Console.WriteLine();
        }
    }
}
