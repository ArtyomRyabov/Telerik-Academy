namespace AnimalHierarchy
{
    using System;
    using System.Linq;

    public class AnimalHierarchyMain
    {
        public static void Main()
        {
            Animal[] animals =
            {
                new Kitten("Kittie", 1),
                new Kitten("Kitt", 1),
                new Tomcat("Tommie", 2),
                new Tomcat("Tom", 3),
                new Cat("Kate", 4, Gender.Female),
                new Cat("Cathy", 3, Gender.Female),
                new Dog("Doggy", 5, Gender.Male),
                new Dog("Doggo", 7, Gender.Male),
                new Frog("Froggie", 1, Gender.Male),
                new Frog("Froggia", 2, Gender.Female)
            };

            Console.WriteLine("Animals:\n");

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
                Console.Write("{0} says: ", animal.GetType().Name);
                animal.ProduceSound();
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', 30));

            Console.WriteLine("\nAnimals' average age:\n");
            AverageAgeByTypes(animals);
            Console.WriteLine();
        }

        private static void AverageAgeByTypes(Animal[] animals)
        {
            var types = new string[] { "Cat", "Dog", "Frog" };

            for (int i = 0; i < types.Length; i++)
			{
                double averageAge = (from animal in animals
                                    where animal.GetType().Name == types[i]
                                    select (double)animal.Age)
                                   .Average();

                Console.WriteLine("{0}: {1:F2} years", types[i], averageAge);
            }
        }
    }
}
