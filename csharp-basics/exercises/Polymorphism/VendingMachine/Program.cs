using System;
using System.Linq;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new Product[]
            {
                new Product(0, new Money (0, 70), "Candy"),
                new Product(1, new Money(1, 20), "CocaCola"),
                new Product (5, new Money (1, 0), "Water"),
                new Product (3, new Money (0, 50), "JumboJuice")
            };
            VendingMachine machine1 = new VendingMachine("Siemens", true, new Money(), products);
            bool isActive = true;

            while (isActive)
            {
                Console.WriteLine("Enter 1 to print products");
                Console.WriteLine("Enter 2 to choose product");
                Console.WriteLine("Enter 3 to exit");

                var input = Console.ReadKey().KeyChar;
                switch (input)
                {
                    case '1': Console.WriteLine(machine1); break;
                    case '2':
                        Console.WriteLine("Enter product name");
                        var productName = Console.ReadLine();
                        Console.WriteLine($"{productName} costs - {machine1.Products.First(x => x.Name == productName).Price}");
                        Console.WriteLine($"Money in machine -> {machine1.Amount}");
                        bool isEntering = true;

                        while (isEntering)
                        {
                            Console.WriteLine("insert Coin -> 2/1/0.50/0.20/0.10");
                            Console.WriteLine("Press 3 to stop");
                            var coin = Console.ReadLine();
                            Money userMoney = new Money();
                            switch (coin)
                            {
                                case "1": userMoney.Euros += int.Parse(coin); break;
                                case "2": userMoney.Euros += int.Parse(coin); break;
                                case "0.50": userMoney.Cents += 50; break;
                                case "0.20": userMoney.Cents += 20; break;
                                case "0.10": userMoney.Cents += 10; break;
                                case "3": isEntering = false; break;
                                default: Console.WriteLine("Wrong coin!"); break;
                            }
                            machine1.InsertCoin(userMoney);
                            Console.WriteLine($"Money in machine -> {machine1.Amount}");
                        }

                        machine1.BuyProduct(productName);
                        break;
                    case '3': isActive = false; break;
                }
            }
        }
    }
}