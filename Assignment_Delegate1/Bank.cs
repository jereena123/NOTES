using System;
using System.Collections.Generic;

namespace Assignment_Delegate1
{
    // DEFINE DELEGATE
    public delegate void TransactionDelegate(decimal amount);

    
    public class Bank
    {
        private Dictionary<int, IBankAccount> accounts = new Dictionary<int, IBankAccount>();

        // Method to add an account to the bank
        public void AddAccount(int accountNumber, decimal initialBalance)
        {
            if (!accounts.ContainsKey(accountNumber))
            {
                IBankAccount account = new BankAccount(accountNumber, initialBalance);
                accounts.Add(accountNumber, account);
                Console.WriteLine($"Account #{accountNumber} created successfully.");
            }
            else
            {
                Console.WriteLine($"Account #{accountNumber} already exists.");
            }
        }

        
       

        // Method to deposit money into an account
        public void Deposit(int accountNumber, decimal amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                IBankAccount account = accounts[accountNumber];
                //INITIALIZE DELEGATE
                TransactionDelegate transaction = new TransactionDelegate(account.Deposit);
                PerformTransaction(accountNumber, amount, transaction);
            }
            else
            {
                Console.WriteLine($"Account #{accountNumber} does not exist.");
            }
        }
        public void PerformTransaction(int accountNumber, decimal amount, TransactionDelegate transaction)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                //INVOKE DELEGATE
                transaction.Invoke(amount);
            }
            else
            {
                Console.WriteLine($"Account #{accountNumber} does not exist.");
            }
        }

        // Method to withdraw money from an account
        public void Withdraw(int accountNumber, decimal amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                IBankAccount account = accounts[accountNumber];
                TransactionDelegate transaction = new TransactionDelegate(account.Withdraw);
                PerformTransaction(accountNumber, amount, transaction);
            }
            else
            {
                Console.WriteLine($"Account #{accountNumber} does not exist.");
            }
        }

        // Method to check balance of an account
        public void CheckBalance(int accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber].CheckBalance();
            }
            else
            {
                Console.WriteLine($"Account #{accountNumber} does not exist.");
            }
        }
    }
}
