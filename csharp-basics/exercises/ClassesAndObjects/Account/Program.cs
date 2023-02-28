using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account bartosAccount = new Account("Barto's account", 100.00);
            Account bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);

            Console.WriteLine("Initial state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            bartosAccount.Withdrawal(20);
            Console.WriteLine("Barto's account balance is now: " + bartosAccount.Balance());
            bartosSwissAccount.Deposit(200);
            Console.WriteLine("Barto's Swiss account balance is now: " + bartosSwissAccount.Balance());

            Console.WriteLine("Final state");
            Console.WriteLine(bartosAccount);
            Console.WriteLine(bartosSwissAccount);

            Account mattsAccount = new Account("Matt's account", 1000);
            Account myAccount = new Account("My account", 0);
            mattsAccount.Withdrawal(100);
            myAccount.Deposit(100.0);
            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);

            Account a = new Account("A", 100.0);
            Account b = new Account("B", 0);
            Account c = new Account("C", 0);
            Account.Transfer(a, b, 50.0);
            Account.Transfer(b, c, 25.0);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.ReadKey();
        }
    }
}
