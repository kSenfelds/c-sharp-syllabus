﻿using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int cars, drivers, passengers, carsNotDriven, carsDriven, seatsInACar, carpoolCapacity;
            double  averagePassengersPerCar;

            cars = 100; 
            seatsInACar = 4;
            drivers = 28;
            passengers = 90;
            carsNotDriven = cars - drivers;
            carsDriven = drivers;
            carpoolCapacity = carsDriven * seatsInACar;
            averagePassengersPerCar = (double)passengers / carpoolCapacity*seatsInACar;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + Math.Round(averagePassengersPerCar, 2) + " in each car.");
            Console.ReadKey();
        }
    }
}