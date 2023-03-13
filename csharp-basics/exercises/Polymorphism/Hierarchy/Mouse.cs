using System;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string name, string animalType, double animalWeight, string livingRegion)
            : base(name, animalType, animalWeight, livingRegion)
        {

        }

        public override void MakeSound()
        {
            Console.WriteLine("Squeek!, Run away from TOM");
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