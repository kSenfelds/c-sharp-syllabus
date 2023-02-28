using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account benben = new Account("Benson", 17.50m);
            Account kriss = new Account("Kriss", 100m);
            Account lea = new Account("Lea", -17.63m);

            Console.WriteLine(benben.ShowUserNameAndBalance());
            Console.WriteLine(kriss.ShowUserNameAndBalance());
            Console.WriteLine(lea.ShowUserNameAndBalance());

            Console.ReadKey();
        }
    }
}
