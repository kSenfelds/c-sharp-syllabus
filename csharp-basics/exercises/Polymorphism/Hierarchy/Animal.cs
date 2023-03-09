using System;

namespace Hierarchy
{
    public abstract class Animal
    {
        private string _name;
        private string _animalType;
        private double _animalWeight;
        public int _foodEaten { get; private set; }

        public Animal(string name, string animalType, double animalWeight)
        {
            _name = name;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = 0;
        }

        public void AddFood(int food)
        {
            _foodEaten = food;
        }

        public abstract void makeSound();

        public abstract void eat(Food food);

        public override string ToString()
        {
            return $"{_animalType} {_name} {String.Format("{0:0.0}", _animalWeight)}";
        }
    }
}