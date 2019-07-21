using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    class BankAccount
    {
        private double money;
        private string owner;

        public BankAccount(double money, string owner)
        {
            this.money = money;
            this.owner = owner;
        }

        public double Money
        {
            get
            {
                return money;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }
        }
        // Overloading + operator
        public static BankAccount operator +(BankAccount bank1, BankAccount bank2)
        {
            double newAmountOfMoney = bank1.Money + bank2.Money;
            string newOwners = bank1.Owner + " + " + bank2.Owner;

            BankAccount newBankAccount = new BankAccount(newAmountOfMoney, newOwners);
            return newBankAccount;
        }

        public static BankAccount operator +(BankAccount bank1, double amount)
        {
            double newAmountOfMoney = bank1.Money + amount;
            string newOwners = bank1.Owner;

            BankAccount newBankAccount = new BankAccount(newAmountOfMoney, newOwners);
            return newBankAccount;
        }
    }
}
