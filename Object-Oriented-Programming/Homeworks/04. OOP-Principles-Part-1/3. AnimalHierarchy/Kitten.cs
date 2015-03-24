namespace AnimalHierarchy
{
    public class Kitten : Cat
    {
        public Kitten(string name, byte age)
            : base(name, age, Gender.female)
        {
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("Kitten: Miau - miau");
        }
    }
}
