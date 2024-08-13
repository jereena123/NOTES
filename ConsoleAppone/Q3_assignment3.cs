using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q3_assignment3
    {
        public static void Main(string[] args)
        {
            int n, r, sum = 0, temp;

            // Prompt the user to enter a number
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());  // Read the number from the user
            temp = n;  // Store the original number to compare later

            // Loop to calculate the sum of the cubes of the digits
            while (n > 0)
            {
                r = n % 10;         // Extract the last digit
                sum = sum + (r * r * r);  // Cube the digit and add to sum
                n = n / 10;         // Remove the last digit
            }

            // Check if the sum of the cubes of the digits equals the original number
            if (temp == sum)
                Console.Write("Armstrong Number.");  
            else
                Console.Write("Not Armstrong Number."); 
        }
    }
}

