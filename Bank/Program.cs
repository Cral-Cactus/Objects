using System;

namespace Bank
{
    internal class Program
    {
        static void Main()
        {
            BankAccount acc = new BankAccount(1);

            acc.Deposit(152);
            acc.Withdraw(5);

            Console.WriteLine(acc.ToString());
        }
    }
}