using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q4_assignment6
   
    {
        // Method to display the first n Fibonacci numbers
        static void DisplayFibonacciSequence(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("Please enter a positive integer.");
                return;
            }

            int first = 0, second = 1;

            Console.WriteLine("Fibonacci sequence:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(first + " ");

                // Compute the next number in the sequence
                int next = first + second;
                first = second;
                second = next;
            }

            Console.WriteLine(); // For a new line after the sequence
        }

        static void Main()
        {
            Console.Write("Enter the number of terms in the Fibonacci sequence: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                DisplayFibonacciSequence(n);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
            }
        }
    }

}

