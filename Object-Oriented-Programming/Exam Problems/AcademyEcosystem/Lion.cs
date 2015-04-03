namespace AcademyEcosystem
{
    public class Lion : Animal, ICarnivore
    {
        private const int LionSize = 6;

        public Lion(string name, Point location)
            : base(name, location, LionSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null && animal.Size <= this.Size * 2)
            {
                this.Size++;
                return animal.GetMeatFromKillQuantity();
            }

            return default(int);
        }
    }
}
