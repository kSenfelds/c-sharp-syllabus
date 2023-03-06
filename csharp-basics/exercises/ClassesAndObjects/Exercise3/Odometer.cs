namespace Exercise3
{
    internal class Odometer
    {
        private double _currentKilometers;
        private FuelGauge _fuelGauge;

        public Odometer(double currentKilometers, FuelGauge fuel)
        {
            _currentKilometers = currentKilometers;
            _fuelGauge = fuel;
        }

        public void Report()
        {
            Console.WriteLine($"Current cars mileage is {_currentKilometers} kilometers and there is {_fuelGauge.GetFuelAmount()} fuel left");
        }

        public double IncrementMileage()
        {
            if (_currentKilometers % 10 == 0)
            {
                _fuelGauge.DecrementFuel();
            }
            return _currentKilometers >= 1000 ? _currentKilometers = 1 : _currentKilometers++;
        }

        public bool AbleToDrive()
        {
            return _fuelGauge.GetFuelAmount() > 0 ? true : false;
        }
    }
}
