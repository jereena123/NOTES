
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Delegate1
{
    public class Program
    {
           static void Main(string[] args)
            {
                Bank bank = new Bank();

                // Adding some sample accounts
                bank.AddAccount(11, 100);
                bank.AddAccount(1002, 00);

                // Menu-driven console
                while (true)
                {
                    Console.WriteLine("\n===== Banking System Menu =====");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice: ");

                    int choice = GetValidIntegerInput();

                    switch (choice)
                    {
                        case 1:
                            PerformDeposit(bank);
                            break;
                        case 2:
                            PerformWithdraw(bank);
                            break;
                        case 3:
                            PerformCheckBalance(bank);
                            break;
                        case 4:
                            Console.WriteLine("Exiting program.");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                            break;
                    }
                }
            }

            // Method to get a valid integer input from the user
            static int GetValidIntegerInput()
            {
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out int result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }

            // Method to get a valid decimal input from the user
            static decimal GetValidDecimalInput()
            {
                while (true)
                {
                    if (decimal.TryParse(Console.ReadLine(), out decimal result))
                    {
                        return result;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid amount.");
                    }
                }
            }

            // Method to perform a deposit operation
            static void PerformDeposit(Bank bank)
            {
                Console.Write("Enter account number: ");
                int accountNumber = GetValidIntegerInput();

                Console.Write("Enter deposit amount: $");
                decimal amount = GetValidDecimalInput();

                bank.Deposit(accountNumber, amount);
            }

            // Method to perform a withdraw operation
            static void PerformWithdraw(Bank bank)
            {
                Console.Write("Enter account number: ");
                int accountNumber = GetValidIntegerInput();

                Console.Write("Enter withdrawal amount: $");
                decimal amount = GetValidDecimalInput();

                bank.Withdraw(accountNumber, amount);
            }

            // Method to perform a check balance operation
            static void PerformCheckBalance(Bank bank)
            {
                Console.Write("Enter account number: ");
                int accountNumber = GetValidIntegerInput();

                bank.CheckBalance(accountNumber);
            }
        }
    }

