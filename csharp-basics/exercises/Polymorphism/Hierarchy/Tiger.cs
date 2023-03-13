using System;

namespace Hierarchy
{
    internal class Tiger : Felime
    {
        public Tiger(string name, string animalType, double animalWeight, string livingRegion)
            : base(name, animalType, animalWeight, livingRegion)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Roarr!, Purr, Purr");
        }

        public override void eat(Food food)
        {
            if (food.GetType() == typeof(Vegetable))
            {
                Console.WriteLine($"{GetType().Name} is not eating that type of food!");
            }
            else
            {
                AddFood(food.Quantity);
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {FoodEaten}";
        }
    }
}