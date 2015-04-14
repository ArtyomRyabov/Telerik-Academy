namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        public Frog(string name, byte age, Gender sex)
            : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("Kwa - kwa");
        }
    }
}
