using System;

namespace Exception_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //  To generate a random number
                int number = GetRandomNumber();
                // Print the generated number
                Console.WriteLine("Generated number: " + number); 
            }
            catch (InvalidOperationException e)
            {
                //  print the exception message
                Console.WriteLine("Exception caught: " + e.Message); 
            }
            Console.ReadKey();
        }

        // Method to generate a random number 
        public static int GetRandomNumber()
        {
            Random random = new Random();
            int number = random.Next(50, 101); // Generates a number between 50 and 100

            if (IsPrime(number)) // Check if the generated number is prime
            {
                // Throw an exception if the number is prime
                throw new InvalidOperationException($"The number {number} is a prime number."); 
            }
            // Return the non-prime number
            return number; 
        }

        // Method to check if a number is prime
        public static bool IsPrime(int number)
        {
            if (number < 2) return false; // Numbers less than 2 are not prime
            if (number == 2) return true; // 2 is prime
            if (number % 2 == 0) return false; // Even numbers greater than 2 are not prime

            for (int i = 3; i <= Math.Sqrt(number); i += 2) // Check odd divisors up to the square root of the number
            {
                if (number % i == 0) return false; // If divisible, it's not prime
            }
            return true; // If no divisors found, it's prime
        }
    }
}
