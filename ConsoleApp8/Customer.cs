using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
    public class Customer
    {
        public string Name;
        public List<Account> Accounts; //TODO: PRINT OUT ACCOUNTS IN LIST
        //public Account DefaultAccount;

        public Customer(string name)
        {
            Name = name;
            //IdGenerator++;
            //DefaultAccount = new Account(Name,"Brukerkonto1");
            Accounts = new List<Account>(); // {DefaultAccount};

        }

        public Account CreateAccount(string accountType)
        {
            var account = new Account(Name, accountType);
            Accounts.Add(account);

            return account;
        }

    }
}
