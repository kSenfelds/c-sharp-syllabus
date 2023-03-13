namespace VendingMachine
{
    public struct Money
    {
        public int Euros { get; set; }
        public int Cents { get; set; }

        public Money(int euros, int cents)
        {
            Euros = euros;
            Cents = cents;
        }

        public override string ToString()
        {
            return $"{Euros}EUR and {Cents} CENTS";
        }
    }
}