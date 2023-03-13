using System;

namespace Hierarchy
{
    public abstract class Animal
    {
        private string _name;
        private string _animalType;
        private double _animalWeight;
        public int FoodEaten { get; private set; }

        public Animal(string name, string animalType, double animalWeight)
        {
            _name = name;
            _animalType = animalType;
            _animalWeight = animalWeight;
            FoodEaten = 0;
        }

        public void AddFood(int food)
        {
            FoodEaten = food;
        }

        public abstract void MakeSound();

        public abstract void eat(Food food);

        public override string ToString()
        {
            return $"{_animalType} {_name} {String.Format("{0:0.0}", _animalWeight)}";
        }
    }
}