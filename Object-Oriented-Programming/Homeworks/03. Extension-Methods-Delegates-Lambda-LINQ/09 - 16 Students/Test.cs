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
            new Student("Gavril", "Gargov", "4213343", "02 588388", "gavril88@mail.bg", 1, new List<int> { 4, 4, 5, 4, 6 }),
            new Student("Simo", "Monkov", "4213339", "0878443536", "simoto@abv.bg", 2, new List<int> { 3, 4, 5, 6, 4 }),
            new Student("Koicho", "Nikolchev", "4213342", "0899776867", "k.nikolchev@mail.bg", 1, new List<int> { 5, 6, 3, 5, 5 }),
            new Student("Simo", "Zazov", "4213340", "0898334455", "zazov222@gmail.com", 2, new List<int> { 2, 2, 3, 3, 4 }),
            new Student("Viara", "Ivanova", "4213344", "0887335263", "viara.ivanova@gmail.com", 1, new List<int> { 6, 6, 6, 6, 5 }),
            new Student("Zuza", "Buzeva", "42133437", "+3592 456776", "zuzata13@abv.bg", 2, new List<int> { 3, 4, 2, 3, 4 })
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
                output.Add(string.Format("{0}, Marks: {1}", student.FullName, string.Join(" ", student.Marks)));
            }

            return output;
        }
    }
}
