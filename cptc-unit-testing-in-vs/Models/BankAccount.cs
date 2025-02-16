using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cptc_unit_testing_in_vs.Models
{
    public class BankAccount
    {
        private string Owner { get; set; }
        public decimal Balance { get; private set; }
        public BankAccount(string owner, decimal balance)
        {
            Owner = owner;
            Balance = balance;
        }
        public decimal Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            Balance += amount;
            return Balance;
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            // overdraft protection
            if (Balance < amount)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            Balance -= amount;
            return Balance;
        }
    }
}
