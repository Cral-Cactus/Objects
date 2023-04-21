using System;

namespace Bank
{
    public class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= 0 || amount > this.Balance)
            {
                return false;
            }

            this.Balance -= amount;

            return true;
        }

        public override string ToString()
        {
            return $"Account {this.ID}, balance {this.Balance:F2}";
        }

        public BankAccount(int id)
        {
            ID = id;
            Balance = 0;
        }
    }
}
