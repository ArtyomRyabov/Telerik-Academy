namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
            new Student("Gavril", "Gargov", "421306", "02 588388", "gavril88@mail.bg", 1, new List<int> { 4, 4, 5, 4, 6 }),
            new Student("Simo", "Monkov", "421333", "0878443536", "simoto@abv.bg", 2, new List<int> { 3, 4, 5, 6, 4 }),
            new Student("Koicho", "Nikolchev", "421206", "0899776867", "k.nikolchev@mail.bg", 1, new List<int> { 5, 6, 3, 5, 5 }),
            new Student("Simo", "Zazov", "421334", "0898334455", "zazov222@gmail.com", 2, new List<int> { 2, 2, 3, 3, 4 }),
            new Student("Viara", "Ivanova", "421335", "0887335263", "viara.ivanova@gmail.com", 1, new List<int> { 6, 6, 6, 6, 5 }),
            new Student("Zuza", "Buzeva", "421337", "+3592 456776", "zuzata13@abv.bg", 2, new List<int> { 3, 4, 2, 2, 4 })
            };

            // Problem 9
            Console.WriteLine("Students from group 2 sorted by first name (using LINQ):");
            Console.WriteLine(string.Join(Environment.NewLine, StudentsByGroupTwoWithLINQ(students)));

            // Problem 10
            Console.WriteLine("\nStudents from group 2 sorted by first name (using lambda):");
            Console.WriteLine(string.Join(Environment.NewLine, StudentsByGroupTwoWithLambda(students)));

            // Problem 11
            Console.WriteLine("\nStudents with email in \"abv.bg\" (using LINQ):");
            Console.WriteLine(string.Join(Environment.NewLine, StudentsByEmailWithLINQ(students)));

            // Problem 12
            Console.WriteLine("\nStudents with Sofian phone number (using LINQ):");
            Console.WriteLine(string.Join(Environment.NewLine, StudentsByPhoneWithLINQ(students)));

            // Problem 13
            Console.WriteLine("\nStudents with excelent mark (using LINQ):");
            Console.WriteLine(string.Join(Environment.NewLine, StudentsWithMark6WithLINQ(students)));

            // Problem 14
            Console.WriteLine("\nStudents with tho marks (2) (using lambda):");
            Console.WriteLine(string.Join(Environment.NewLine, StudentsWithTwoMarks2WithLambda(students)));

            // Problem 15
            Console.WriteLine("\nStudents that enrolled in 2006:");
            Console.WriteLine(string.Join(Environment.NewLine, StudentsEnrolled2006(students)));

            // Problem 16
            Console.WriteLine("\nStudents from 'Mathematics' department:");
            StudentsFromMathematicsDepartment(students);
        }

        //Problem 9
        private static IEnumerable<Student> StudentsByGroupTwoWithLINQ(List<Student> students)
        {
            return from student in students
                   where student.GroupNumber == 2
                   orderby student.FirstName
                   select student;
        }

        // Problem 10
        private static IEnumerable<Student> StudentsByGroupTwoWithLambda(List<Student> students)
        {
            return students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
        }

        //Problem 11
        private static IEnumerable<Student> StudentsByEmailWithLINQ(List<Student> students)
        {
            return from student in students
                   where student.Email.EndsWith("abv.bg")
                   select student;
        }

        //Problem 12
        private static IEnumerable<Student> StudentsByPhoneWithLINQ(List<Student> students)
        {
            return from student in students
                   where student.PhoneNumber.Contains("(02)") || student.PhoneNumber.StartsWith("02") ||
                         student.PhoneNumber.StartsWith("+3592")
                   select student;
        }

        //Problem 13
        private static IEnumerable<string> StudentsWithMark6WithLINQ(List<Student> students)
        {
            var newStudents = from student in students
                              where student.Marks.Contains(6)
                              select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            List<string> output = new List<string>();

            foreach (var student in newStudents)
            {
                output.Add(string.Format("{0}, Marks: {1}", student.FullName, string.Join(", ", student.Marks)));
            }

            return output;
        }

        //Problem 14
        private static IEnumerable<Student> StudentsWithTwoMarks2WithLambda(List<Student> students)
        {
            return students.Where(st => st.Marks.FindAll(m => m == 2).Count >= 2);
        }

        // Problem 15
        private static IEnumerable<string> StudentsEnrolled2006(List<Student> students)
        {
            var newStudents = students.Where(st => st.FacultyNumber.EndsWith("06"));

            List<string> output = new List<string>();

            foreach (var student in newStudents)
            {
                output.Add(string.Format("{0} {1}, Marks: {2}", student.FirstName, student.LastName, string.Join(", ", student.Marks)));
            }

            return output;
        }

        // Problem 16
        private static void StudentsFromMathematicsDepartment(List<Student> students)
        {
            List<Group> groups = new List<Group>()
            {
                new Group(1, "Mathematics"),
                new Group(2, "Physics")
            };

            var mathStudents = from student in students
                               join gr in groups on student.GroupNumber equals gr.GroupNumber
                               where gr.DepartmentName == "Mathematics"
                               select (string.Format("{0} {1}, GR: {2}, Department: {3}", student.FirstName, student.LastName,
                                       student.GroupNumber, gr.DepartmentName));

            List<string> output = new List<string>();

            foreach (var student in mathStudents)
            {
                Console.WriteLine(student);
            }
        }
    }
}
