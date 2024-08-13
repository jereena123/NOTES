using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q8_assignment6
    {
       

class Program
    {
        // Recursive method to print even numbers in the range [start, end]
        static void PrintEvenNumbers(int start, int end)
        {
            if (start > end)
            {
                return;
            }

            if (start % 2 == 0)
            {
                Console.Write(start + " ");
            }

            PrintEvenNumbers(start + 1, end);
        }

        // Recursive method to print odd numbers in the range [start, end]
        static void PrintOddNumbers(int start, int end)
        {
            if (start > end)
            {
                return;
            }

            if (start % 2 != 0)
            {
                Console.Write(start + " ");
            }

            PrintOddNumbers(start + 1, end);
        }

        static void Main()
        {
            Console.Write("Enter the start of the range: ");
            if (!int.TryParse(Console.ReadLine(), out int start))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the start of the range.");
                return;
            }

            Console.Write("Enter the end of the range: ");
            if (!int.TryParse(Console.ReadLine(), out int end))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer for the end of the range.");
                return;
            }

            Console.WriteLine("Even numbers in the range:");
            PrintEvenNumbers(start, end);
            Console.WriteLine(); // New line for formatting

            Console.WriteLine("Odd numbers in the range:");
            PrintOddNumbers(start, end);
            Console.WriteLine(); // New line for formatting
        }
    }

}
}
