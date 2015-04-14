namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        public Cat(string name, byte age, Gender sex)
            : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("Miau - miau");
        }
    }
}
