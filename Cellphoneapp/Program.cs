using System;
using System.Collections.Generic;
using System.Linq;

namespace Cellphoneapp
{ 
   public class Program
{
    static Account[] accounts = new Account[100];
    static int accountCount = 0;

    static void Main(string[] args)
    {
        // MENU
        while (true)
        {
            Console.WriteLine("\nCellPhone Accounts System");
            Console.WriteLine("1. Add New Account");
            Console.WriteLine("2. Display All Accounts");
            Console.WriteLine("3. Search Account by Cellphone Number");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your choice:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNewAccount();
                    break;
                case "2":
                    DisplayAllAccounts();
                    break;
                case "3":
                    SearchAccount();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("INVALID CHOICE, PLEASE TRY AGAIN");
                    break;
            }
        }
    }

    private static void SearchAccount()
    {
        Console.WriteLine("Enter Cellphone Number to Search:");
        string cellphoneNumber = Console.ReadLine();

        var account = accounts.FirstOrDefault(a => a.CellphoneNumber == cellphoneNumber);
        if (account != null)
        {
            Console.WriteLine($"Account Found: {account}");
            account.DisplayDetails();
        }
        else
        {
            Console.WriteLine("Account not found.");
        }
    }

    private static void DisplayAllAccounts()
    {
        if (accountCount == 0)
        {
            Console.WriteLine("No accounts to display.");
            return;
        }

        foreach (var account in accounts.Take(accountCount))
        {
            account.DisplayDetails();
        }
    }

    private static void AddNewAccount()
    {
        Console.WriteLine("Add New Account");

        if (accountCount >= accounts.Length)
        {
            Console.WriteLine("Account Storage is full. Can't add more.");
            return;
        }

        Console.WriteLine("\nSelect Account Type:");
        Console.WriteLine("1. Contract");
        Console.WriteLine("2. Pay As You Go");
        Console.WriteLine("Enter your Choice:");
        string accountTypeChoice = Console.ReadLine();

        Console.WriteLine("Enter Cellphone Number:");
        string cellphoneNumber = Console.ReadLine();

        Console.WriteLine("Enter Total Call Time in Minutes:");
        int totalCallTime = GetValidIntegerInput();

        Console.WriteLine("Enter Total Cost of Calls:");
        decimal totalCostOfCalls = GetValidDecimalInput();

        if (accountTypeChoice == "1")
        {
            Console.Write("Enter Account Holder Name: ");
            string accountHolderName = Console.ReadLine();

            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Contract Length in Months: ");
            int contractLength = GetValidIntegerInput();

            accounts[accountCount++] = new Contract(cellphoneNumber, totalCallTime, totalCostOfCalls, accountHolderName, address, contractLength);
        }
        else if (accountTypeChoice == "2")
        {
            Console.Write("Enter Call Type: ");
            int callType = GetValidIntegerInput();
            accounts[accountCount++] = new PayAsYouGo(cellphoneNumber, totalCallTime, totalCostOfCalls, callType);
        }
        else
        {
            Console.WriteLine("Invalid Account Type choice.");
        }
    }

    private static int GetValidIntegerInput()
    {
        int validInput;
        while (!int.TryParse(Console.ReadLine(), out validInput))
        {
            Console.WriteLine("Invalid Input. Please Enter a Valid Integer:");
        }
        return validInput;
    }

    private static decimal GetValidDecimalInput()
    {
        decimal validDecimal;
        while (!decimal.TryParse(Console.ReadLine(), out validDecimal))
        {
            Console.WriteLine("Invalid Input. Please Enter a Valid Decimal:");
        }
        return validDecimal;
    }
}
}