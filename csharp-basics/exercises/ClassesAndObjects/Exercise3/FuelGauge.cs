namespace Exercise3
{
    internal class FuelGauge
    {
        private double _fuelAmount;

        public double GetFuelAmount()
        {
            return _fuelAmount;
        }

        public double IncrementFuel()
        {
            if (_fuelAmount > 70)
            {
                Console.WriteLine($"You are going over the tank limit - 70 liters");
                return _fuelAmount;
            }
            else
            {
                return _fuelAmount++;
            }
        }

        public double DecrementFuel()
        {
            return _fuelAmount > 0 ? _fuelAmount-- : _fuelAmount;
        }
    }
}
