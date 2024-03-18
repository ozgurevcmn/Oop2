using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop2
{
    // BankAccount class with encapsulation
    class BankAccount
    {
        private string accountNumber;
        private decimal balance;

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {accountNumber}, Balance: {balance:C}");
        }
    }
}
