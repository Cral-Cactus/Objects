﻿using Bank;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonMoney
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public List<BankAccount> Accounts
        {
            get
            {
                return this.accounts;
            }
            set
            {
                this.accounts = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Accounts = new List<BankAccount>();
        }

        public double GetBalance()
        {
            return this.Accounts.Sum(a => a.Balance);
        }
    }
}