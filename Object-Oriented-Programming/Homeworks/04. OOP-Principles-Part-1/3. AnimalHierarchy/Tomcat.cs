namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, byte age)
            : base(name, age, Gender.Male)
        {
        }

        public override void ProduceSound()
        {
            System.Console.WriteLine("Tomcat: Miau - miau");
        }
    }
}
