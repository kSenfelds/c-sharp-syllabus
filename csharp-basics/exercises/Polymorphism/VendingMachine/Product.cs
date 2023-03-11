namespace VendingMachine
{
    public struct Product
    {
        public int Available { get; set; }
        public Money Price { get; set; }
        public string Name { get; set; }

        public Product(int available, Money price, string name)
        {
            Available = available;
            Price = price;
            Name = name;
        }

        public bool IsAvailable()
        {
            return Available > 0;
        }

        public void DecreaseCount()
        {
            Available--;
        }

        public bool CanAfford(Money amount)
        {
            return Price.Euros < amount.Euros || (Price.Euros == amount.Euros && Price.Cents <= amount.Cents);
        }
    }
}