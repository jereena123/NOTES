using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q5_assignment6


    { 
class Program
    {
        // Method to check if a number is prime
        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }

            // Check for factors from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            Console.Write("Enter a number to check if it is prime: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                bool isPrime = IsPrime(number);
                if (isPrime)
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

}
    }
