namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales;
        private double _commisionRate;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            _commisionRate = commissionRate;
            _totalSales = 0.0;
        }

        public void AddSales(double sales)
        {
            _totalSales += sales;
        }

        public override double Pay()
        {
            var result = base.Pay();
            result += _totalSales * _commisionRate;
            _totalSales = 0;
            return result;
        }

        public override string ToString()
        {
            var print = base.ToString();
            print += "\nTotal sales: " + _totalSales;
            return print;
        }
    }
}
