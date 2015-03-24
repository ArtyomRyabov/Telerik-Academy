namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;

    public class Test
    {
        public static void Main()
        {
            School school = new School("Test School");
            Console.WriteLine("School name: \"{0}\"\n", school.Name);

            var students = new List<Student>
            {
                new Student("Grafa", 1, "Class leader"),
                new Student("Mara", 2),
                new Student("Miro", 3),
                new Student("Lyubcho", 4)
            };

            Console.WriteLine("\nList of students:\n");

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            var disciplines = new List<Discipline>
            {
                new Discipline("Maths", 15, 15)
            };

            Discipline physics = new Discipline("Physics", 10, 10, "New discipline");
            disciplines.Add(physics);

            Console.WriteLine("\n\nList of disciplines:\n");

            foreach (var discipline in disciplines)
            {
                Console.WriteLine(discipline);
                Console.WriteLine();
            }

            Teacher petrova = new Teacher("Tsanka Petrova", new List<Discipline>() { new Discipline("Physics", 10, 10, "New discipline") });
            Teacher pavlov = new Teacher("Tosho Pavlov", new List<Discipline>() { new Discipline("Maths", 10, 10) });

            List<Teacher> teachers = new List<Teacher>() { petrova, pavlov };
            
            Console.WriteLine("\nList of teachers:\n");

            foreach (Teacher teacher in teachers)
            {
                Console.WriteLine(teacher);
                Console.WriteLine();
            }

            Class tenA = new Class("10 A", 
                                   new List<Teacher>() { petrova }, 
                                   new List<Student>() { new Student("Todor", 1), new Student("Yana", 2) });

            Console.Write("\nClass: ");
            Console.WriteLine(tenA);

            tenA.Comment = "Very good results last year!";
            Console.WriteLine("\n\nClass \"{0}\" comment: {1}", tenA.ClassID, tenA.Comment);


        }
    }
}
