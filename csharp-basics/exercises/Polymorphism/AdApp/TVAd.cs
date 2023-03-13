namespace AdApp
{
    public class TVAd : Advert
    {
        private int _seconds;
        private int _rate;
        private bool _isPeak;

        public TVAd(int fee, int seconds, int rate, bool isPeakTime) : base(fee)
        {
            _seconds = seconds;
            _rate = rate;
            _isPeak = isPeakTime;
        }

        public new int Cost()
        {
            var totalCost = base.Cost();
            totalCost += _seconds * _rate;
            totalCost += _isPeak ? totalCost * 2 : 0;
            SetFee(totalCost);
            return totalCost;
        }

        public override string ToString()
        {
            return "\nTV advertisement: Fee=" + Cost();
        }
    }
}