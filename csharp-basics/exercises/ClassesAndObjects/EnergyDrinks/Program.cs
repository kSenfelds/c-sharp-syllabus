using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int _numberedSurveyed = 12467;
        private const double _purchasedEnergyDrinks = 0.14;
        private const double _preferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            Program survey = new Program();
            Console.WriteLine("Total number of people surveyed " + _numberedSurveyed);
            Console.WriteLine("Approximately " + survey.CalculateEnergyDrinkers(_numberedSurveyed) + " bought at least one energy drink");
            Console.WriteLine(survey.CalculatePreferCitrus(_numberedSurveyed) + " of those " + "prefer citrus flavored energy drinks.");
            Console.ReadKey();
        }

        double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return (double)numberSurveyed * _purchasedEnergyDrinks;
        }

        double CalculatePreferCitrus(int numberSurveyed)
        {
            return CalculateEnergyDrinkers(numberSurveyed) * _preferCitrusDrinks;
        }
    }
}
