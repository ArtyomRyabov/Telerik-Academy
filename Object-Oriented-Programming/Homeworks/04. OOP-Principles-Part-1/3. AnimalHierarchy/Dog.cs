namespace AnimalHierarchy
{
    public class Dog : Animal
    {
        public Dog(string name, byte age, Gender sex)
            : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("Bau - bau");
        }
    }
}
