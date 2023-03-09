using System;

namespace Hierarchy
{
    internal class Cat : Felime
    {
        private string _breed;

        public Cat(string breed, string name, string animalType, double animalWeight, string livingRegion)
            : base(name, animalType, animalWeight, livingRegion)
        {
            _breed = breed;
        }

        public override void makeSound()
        {
            Console.WriteLine("Meoww, Purr, Purr");
        }

        public override void eat(Food food)
        {
            AddFood(food.Quantity);
        }

        public override string ToString()
        {
            return $"{base.ToString()} {_breed} {_foodEaten}";
        }
    }
}