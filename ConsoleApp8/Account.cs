using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class Account
    {
        public string AccountType;
        public string OwnerId;
        public List<Transaction> Transactions;
        public int Balance;
        //public bool IsDefaultAccount;

        public Account(string ownerID, string accountType)
        {
            OwnerId = ownerID;
            AccountType = accountType;
            Transactions = new List<Transaction>();
        }       

        public void Deposit(int deposit)
        {
            Balance += deposit;
            //Transactions.Add();
        }

        public static void Transfer(Customer customer, Account account1, Account account2, int sum)
        {
            if (customer.Name != account2.OwnerId) return;
            account2.Balance -= sum;
            account1.Balance += sum;
            //Transactions.Add()
        }
    }
}
