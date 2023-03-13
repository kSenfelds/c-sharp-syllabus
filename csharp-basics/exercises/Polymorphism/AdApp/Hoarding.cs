namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _rate;
        private int _numDays;
        private bool _isPrimeLocation;

        public Hoarding(int fee, int days, int rate, bool isPrimeLocation) : base(fee)
        {
            _rate = rate;
            _numDays = days;
            _isPrimeLocation = isPrimeLocation;
        }

        public new int Cost()
        {
            var totalCost = base.Cost();
            totalCost += _rate * _numDays;
            totalCost += _isPrimeLocation ? (int)(totalCost * 0.5d) : 0;
            SetFee(totalCost);

            return totalCost;
        }

        public override string ToString()
        {
            return "\nHoarding: Fee=" + Cost();
        }
    }
}