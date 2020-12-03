using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Terje");
            var debitAccount = customer.CreateAccount("Brukskonto");
            var savingsAccount = customer.CreateAccount("Sparekonto");
            debitAccount.Deposit(1000);
            Account.Transfer(customer, savingsAccount, debitAccount, 200);
            Console.WriteLine(debitAccount.Balance);
            Console.WriteLine(savingsAccount.Balance);

        }
    }
}
