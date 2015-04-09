namespace AcademyEcosystem
{
    public class Zombie : Animal
    {
        private const int ZombieSize = 0;
        private const int Meat = 10;

        public Zombie(string name, Point location)
            : base(name, location, ZombieSize)
        {
            this.IsAlive = true;
        }

        public override int GetMeatFromKillQuantity()
        {
            return Meat;
        }
    }
}
