namespace StudentClass
{
    using System;

    public class Test
    {
        public static void Main()
        {
            Student firstStudent = new Student("Ivan", "Vasilev", "Georgiev", "234-23-4567", "Address", "0888345678", "ivan@abv.bg",
                                               1, Specialty.Biology, University.PlovdivUniversity, Faculty.BiologyFaculty);

            Console.WriteLine("First student:\n\n" + firstStudent);
            Console.WriteLine("First student hash code: {0}\n", firstStudent.GetHashCode());

            Student secondStudent = firstStudent;
            Console.WriteLine("Second student:\n\n" + secondStudent);

            Console.WriteLine("DoesReferenceEquals(firstStudent, secondStudent)? : {0}\n", ReferenceEquals(firstStudent, secondStudent));

            Student thirdStudent = (Student)secondStudent.Clone();
            Console.WriteLine("Third student (cloned second student):\n\n" + thirdStudent);

            Console.WriteLine("DoesReferenceEquals(thirdStudent, secondStudent)? : {0}\n", ReferenceEquals(thirdStudent, secondStudent));

            secondStudent = new Student("Peter", "Pavlov", "Petrov", "888-23-4567", "Address", "0888345888", "peter@gmail.com",
                                        2, Specialty.Chemistry, University.SofiaUniversity, Faculty.ChemistryFaculty);

            Console.WriteLine("Second student (changed):\n\n" + secondStudent);
            Console.WriteLine("Third student:\n\n" + thirdStudent);

            Console.WriteLine("firstStudent != secondStudent : {0}", firstStudent != secondStudent);
            Console.WriteLine("firstStudent.Equals(secondStudent)) : {0}", firstStudent.Equals(secondStudent));
            Console.WriteLine("firstStudent.CompareTo(secondStudent) : {0}", firstStudent.CompareTo(secondStudent));
        }
    }
}
