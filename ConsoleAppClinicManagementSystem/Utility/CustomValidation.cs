using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Utility
{
    public class CustomValidation
    {
       

            // Validate username: should not be empty and match allowed characters
            public static bool IsValidUserName(string userName)
            {
                return !string.IsNullOrWhiteSpace(userName) &&
                      Regex.IsMatch(userName, @"^[a-zA-Z0-9_. ]+$");
            }

            // Validate password: should not be empty and meet complexity requirements
            public static bool IsValidPassword(string password)
            {
                return !string.IsNullOrWhiteSpace(password) &&
                      Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{4,}$");
            }

            // Read password input and mask it with asterisks
            public static string ReadPassword()
            {
                string password = "";
                ConsoleKeyInfo key;

                do
                {
                    key = Console.ReadKey(true);

                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        password += key.KeyChar;
                        Console.Write("*");
                    }
                    else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                    {
                        password = password.Substring(0, password.Length - 1);
                        Console.Write("\b \b");
                    }

                } while (key.Key != ConsoleKey.Enter);

                Console.WriteLine();
                return password;
            }
        }
    }
