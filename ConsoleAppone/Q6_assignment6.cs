using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q6_assignment6
    { 

class Program
    {
        // Method to calculate the sum of individual digits of a number
        static int SumOfDigits(int number)
        {
            int sum = 0;

            // Handle negative numbers by taking the absolute value
            number = Math.Abs(number);

            while (number > 0)
            {
                sum += number % 10;  // Add the last digit to sum
                number /= 10;         // Remove the last digit
            }

            return sum;
        }

        static void Main()
        {
            Console.Write("Enter a number to calculate the sum of its digits: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                int sum = SumOfDigits(number);
                Console.WriteLine($"The sum of the digits of {number} is {sum}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

}
}
