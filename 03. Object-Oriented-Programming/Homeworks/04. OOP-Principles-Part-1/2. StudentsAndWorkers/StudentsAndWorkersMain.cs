namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsAndWorkersMain
    {
        public static void Main()
        {
            var students = new List<Student>
            {
                new Student("Todor", "Atanasov", 4.2),
                new Student("Todor", "Georgiev", 6),
                new Student("Ivan", "Georgiev", 3.35),
                new Student("Gavril", "Sotev", 5.4),
                new Student("Toni", "Dimitrov", 5.6),
                new Student("Veska", "Koleva", 3.55),
                new Student("Nora", "Notova", 4.65),
                new Student("Dragan", "Donkov", 5.4),
                new Student("Vasil", "Tsonev", 2.5),
                new Student("Zoran", "Goranovich", 4.35),
            };

            var ascendingSortedStudents = students.OrderBy(st => st.Grade);

            Console.WriteLine("Students sorted by grade (ascending):\n");
            Console.WriteLine(string.Join("\n", ascendingSortedStudents));

            var workers = new List<Worker>
            {
                new Worker("Niki", "Kolev", 350, 8),
                new Worker("Yavor", "Nonov", 300, 8),
                new Worker("Georgi", "Yotov", 275, 8),
                new Worker("Gina", "Moneva", 380, 8),
                new Worker("Krasi", "Minev", 230, 8),
                new Worker("Vasil", "Donchev", 230, 8),
                new Worker("Vladimir", "Vasilev", 260, 4),
                new Worker("Dimitar", "Tabakov", 320, 8),
                new Worker("Veselin", "Chipilov", 235, 4),
                new Worker("Angel", "Vasilev", 400, 6)
            };

            var moneyPerHourSortedDescendingWorkers = from worker in workers
                                                      orderby worker.MoneyPerHour() descending
                                                      select worker;

            Console.WriteLine("\n\nWorkers sorted by 'money per hour' (descending):\n");
            Console.WriteLine(string.Join("\n", moneyPerHourSortedDescendingWorkers));

            var mergeStudentsAndWorkers = new List<Human>();
            mergeStudentsAndWorkers.AddRange(students);
            mergeStudentsAndWorkers.AddRange(workers);

            var sorted = mergeStudentsAndWorkers.OrderBy(m => m.FirstName).ThenBy(m => m.LastName);

            Console.WriteLine("\n\nStudents and workers merged and sorted by first and last name :\n");

            foreach (Human man in sorted)
            {
                Console.WriteLine("{0} {1}", man.FirstName, man.LastName);
            }

            Console.WriteLine();
        }
    }
}
