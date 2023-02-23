﻿using System;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            int[] numbersArray = new int[maxNumber - minNumber + 1];
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = minNumber;
                sum += numbersArray[i];
                minNumber++;
            }

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
