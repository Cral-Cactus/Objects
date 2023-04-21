using Bank;
using System;

namespace PersonMoney
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] inputParts = input.Split(' ');
            string name = inputParts[0];
            int age = int.Parse(inputParts[1]);

            Person person = new Person(name, age);
            BankAccount account1 = new BankAccount(1);
            BankAccount account2 = new BankAccount(2);

            account1.Deposit(9);
            account2.Deposit(60);

            person.Accounts.Add(account1);
            person.Accounts.Add(account2);

            Console.WriteLine($"Total balance for {person.Name} is ${person.GetBalance()}.");
        }
    }
}