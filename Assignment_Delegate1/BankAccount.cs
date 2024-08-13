using System;

namespace Assignment_Delegate1
{
  

    
    public class BankAccount : IBankAccount
    {
        public int AccountNumber { get; private set; }
        public decimal Balance { get; private set; }

        public BankAccount(int accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited ${amount}. Current balance: ${Balance}");
        }

        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn ${amount}. Current balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        // Method to check current balance
        public void CheckBalance()
        {
            Console.WriteLine($"Account #{AccountNumber} Balance: ${Balance}");
        }
    }
}
