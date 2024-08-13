using System;

namespace ConsoleAppone
{
    internal class Q4_assignment3
    {
        public static void Main()
        {
            //  user to enter a number
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());  // Read the number from user input
            int a = 0;  // initialize

            // Loop from 1 to n to check for divisors
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)  // Check if i is a divisor of n
                {
                    a++;  // Increment the value for each divisor
                }
            }

            // Check if the number of divisors is exactly 2 
            if (a == 2)
            {
                Console.WriteLine("{0} is a Prime Number", n);
            }
            else
            {
                Console.WriteLine("{0} is Not a Prime Number", n);
            }

            Console.ReadLine();  
        }
    }
}
