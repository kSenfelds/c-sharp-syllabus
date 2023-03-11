namespace VendingMachine
{
    public interface IVendingMachine
    {
        public string Manufacturer { get; }
        public bool HasProducts { get; }
        public Money Amount { get; }
        Product[] Products { get; set; }
        public Money InsertCoin(Money amount);

        public Money ReturnMoney();

        public bool AddProduct(string name, Money price, int count);

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount);
    }
}