using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q7_assignment6
    { 

class Program
    {
        // Recursive method to display the individual digits of a number
        static void DisplayDigits(int number)
        {
            if (number == 0)
            {
                return;
            }

            // Recursive call with the number divided by 10
            DisplayDigits(number / 10);

            // Print the last digit
            Console.Write(number % 10 + " ");
        }

        static void Main()
        {
            Console.Write("Enter a number to display its digits: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.Write("The digits of the number are: ");
                DisplayDigits(number);
                Console.WriteLine(); // New line for formatting
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

}
}
