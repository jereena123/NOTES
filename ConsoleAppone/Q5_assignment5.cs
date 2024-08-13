using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q5_assignment5
    { 
        static void Main()
        {
            // Input string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Initialize counters
            int alphabetCount = 0;
            int digitCount = 0;
            int specialCharCount = 0;

            // Count alphabets, digits, and special characters
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else if (char.IsDigit(c))
                {
                    digitCount++;
                }
                else if (!char.IsWhiteSpace(c))
                {
                    specialCharCount++;
                }
            }

            // Display the results
            Console.WriteLine($"Total number of alphabets: {alphabetCount}");
            Console.WriteLine($"Total number of digits: {digitCount}");
            Console.WriteLine($"Total number of special characters: {specialCharCount}");
        }
    }
}
