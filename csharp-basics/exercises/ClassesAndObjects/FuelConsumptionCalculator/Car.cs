using System;
namespace FuelConsumptionCalculator
{
    public class Car
    {
        private double _startKilometers;
        private double _endKilometers;
        private double _liters;
        public Car(double startOdo)
        {
            _startKilometers= startOdo;
        }

        public double CalculateConsumption()
        {
            return ConsumptionPer100Km();
        }

        private double ConsumptionPer100Km()
        {

            return (_liters / _endKilometers)*100;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            _endKilometers += mileage ;
            _liters += liters;
        }
    }
}
