using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine1 = new VendingMachine("Siemens", true, new Money(), new Product[] { new Product(10, new Money(), "Ice") });

            Money fiftyCent = new Money();
            fiftyCent.Cents = 50;
            Money twentyCent= new Money();
            twentyCent.Cents = 20;
            machine1.InsertCoin(fiftyCent);
            machine1.InsertCoin(twentyCent);
            machine1.InsertCoin(fiftyCent);

            Console.WriteLine("in machine "+machine1.Amount.Euros.ToString());
            Console.WriteLine(machine1.AddProduct("Ice", fiftyCent, 10));
        }
    }
}
