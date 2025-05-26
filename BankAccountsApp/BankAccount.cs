using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    public class BankAccount
    {
        public string Owner { get; set; }
        public string AccountType { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; protected set; }


        public BankAccount(string owner)
        {
            Owner = owner;
            AccountType = "Checking";
            AccountNumber = Guid.NewGuid();
            Balance = 0;
        }

        public virtual string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You can not deposit $" + amount;
            if (amount > 20000)
                return "AML Deposit Limit Reached.";

            Balance += amount;
            return "Deposit completed successfully.";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "You can not withdraw $" + amount;
            if (amount > Balance)
                return "Withdraw unsuccessful. Insufficient funds.";

            Balance -= amount;
            return "Withdraw completed successfully.";
        }
    }
}
