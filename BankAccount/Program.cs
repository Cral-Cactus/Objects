using Bank;
using System;
using System.Collections.Generic;

namespace BankAccounts
{
    internal class Program
    {
        static Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        static void Main()
        {
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];

                int accountId = 0;
                double amount = 0;

                if (input.Length > 1) int.TryParse(input[1], out accountId);
                if (input.Length > 2) double.TryParse(input[2], out amount);

                switch (command)
                {
                    case "Create":
                        CreateAccount(accountId);
                        break;
                    case "Deposit":
                        Deposit(accountId, amount);
                        break;
                    case "Withdraw":
                        Withdraw(accountId, amount);
                        break;
                    case "Print":
                        Print(accountId);
                        break;
                    case "End":
                        return;
                }
            }
        }

        static void CreateAccount(int id)
        {
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists!");
                return;
            }

            accounts[id] = new BankAccount(id);
        }

        static void Deposit(int id, double amount)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            accounts[id].Deposit(amount);
        }

        static void Withdraw(int id, double amount)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            bool success = accounts[id].Withdraw(amount);
            if (!success)
            {
                Console.WriteLine("Insufficient balance");
            }
        }

        static void Print(int id)
        {
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
                return;
            }

            Console.WriteLine(accounts[id].ToString());
        }
    }
}