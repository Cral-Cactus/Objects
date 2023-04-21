using System;

namespace Bank
{
    internal class Program
    {
        static void Main()
        {
            BankAccount acc = new BankAccount(1);

            acc.Deposit(15);
            acc.Withdraw(5);

            Console.WriteLine($"Account {acc.ID}, balance {acc.Balance:F2}");
        }
    }
}