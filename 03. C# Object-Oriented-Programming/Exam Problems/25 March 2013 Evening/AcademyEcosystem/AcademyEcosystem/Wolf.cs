﻿namespace AcademyEcosystem
{
    public class Wolf : Animal, ICarnivore
    {
        private const int WolfSize = 4;

        public Wolf(string name, Point location)
            : base(name, location, WolfSize)
        {
        }

        public int TryEatAnimal(Animal animal)
        {
            if (animal != null && (animal.Size <= this.Size || animal.State == AnimalState.Sleeping))
            {
                return animal.GetMeatFromKillQuantity();
            }

            return default(int);
        }
    }
}
