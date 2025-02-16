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
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
