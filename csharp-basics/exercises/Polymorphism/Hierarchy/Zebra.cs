using System;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string name, string animalType, double animalWeight, string livingRegion)
            : base(name, animalType, animalWeight, livingRegion)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Tototodurutututu Circus!");
        }

        public override void eat(Food food)
        {
            if (food.GetType() == typeof(Meat))
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