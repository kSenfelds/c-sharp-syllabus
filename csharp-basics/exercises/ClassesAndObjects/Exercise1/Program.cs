namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product logitechMouse = new Product("Logitech mouse", 70.00m, 14);
            Product iPhone5 = new Product("iPhone 5s", 999.99m, 3);
            Product epsonEb = new Product("Epson EB-U05", 440.46m, 1);

            logitechMouse.PrintProduct();
            iPhone5.PrintProduct();
            epsonEb.PrintProduct();

            logitechMouse.ChangeAmount(13);
            logitechMouse.ChangePrice(75.00m);
            logitechMouse.PrintProduct();
        }
    }
}