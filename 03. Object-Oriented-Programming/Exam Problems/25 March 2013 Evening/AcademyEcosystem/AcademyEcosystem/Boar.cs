namespace AcademyEcosystem
{
    public class Boar : Animal, IHerbivore, ICarnivore
    {
        private const int BoarBiteSize = 2;
        private const int BoarSize = 4;

        public Boar(string name, Point location)
            : base(name, location, BoarSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null && animal.Size <= this.Size)
            {
                return animal.GetMeatFromKillQuantity();
            }

            return default(int);
        }

        public int EatPlant(Plant plant)
        {
            if (plant == null)
            {
                return default(int);
            }

            this.Size++;
            int eatenQuantity = plant.GetEatenQuantity(BoarBiteSize);

            return eatenQuantity;
        }
    }
}
