namespace GroupedByGroupNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Students;

    public class GroupStudentByGroupNumber
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

            // Problem 18
            Console.WriteLine("Students grouped by GroupNumber (using LINQ):\n");

            var groupedStudentsLINQ = from student in students
                                      orderby student.GroupNumber
                                      select (string.Format("{0} {1}, GroupNumber: {2}", student.FirstName, student.LastName, student.GroupNumber));

            Console.WriteLine(String.Join(Environment.NewLine, groupedStudentsLINQ));

            // Problem 19
            Console.WriteLine("\n\nStudents grouped by GroupNumber (using extention):\n");

            var groupedStudentsExt = students
                .OrderBy(x => x.GroupNumber)
                .Select(x => string.Format("{0} {1}, GroupNumber: {2}", x.FirstName, x.LastName, x.GroupNumber));

            Console.WriteLine(String.Join(Environment.NewLine, groupedStudentsExt));
            Console.WriteLine();
        }
    }
}
