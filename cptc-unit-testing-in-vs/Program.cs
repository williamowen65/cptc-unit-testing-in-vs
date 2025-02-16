using cptc_unit_testing_in_vs.Models;

namespace cptc_unit_testing_in_vs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99m);
            ba.Deposit(5.77m);
            ba.Withdraw(11.22m);
            Console.WriteLine($"Current balance is {ba.Balance}");
        }
    }
}
