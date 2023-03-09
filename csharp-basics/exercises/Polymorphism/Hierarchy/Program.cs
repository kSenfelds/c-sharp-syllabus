using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter info - {AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} [{CatBreed} = Only if its cat]");
                var input = Console.ReadLine();
                var info = input.Split(' ');

                switch (info[0])
                {
                    case "Cat": animalList.Add(new Cat(info[4], info[1], info[0], double.Parse(info[2]), info[3])); break;
                    case "Tiger": animalList.Add(new Tiger(info[1], info[0], double.Parse(info[2]), info[3])); break;
                    case "Zebra": animalList.Add(new Zebra(info[1], info[0], double.Parse(info[2]), info[3])); break;
                    case "Mouse": animalList.Add(new Mouse(info[1], info[0], double.Parse(info[2]), info[3])); break;
                }

                animalList[i].makeSound();
                Console.WriteLine("Enter food info - {FoodType} {Quantity}");
                input = Console.ReadLine();
                info = input.Split(' ');
                Food food = info[0] == "Vegetable" ? new Vegetable(int.Parse(info[1])) : new Meat(int.Parse(info[1]));
                animalList[i].eat(food);
                Console.WriteLine(animalList[i]);
            }
        }
    }
}