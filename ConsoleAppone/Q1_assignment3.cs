using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q1_assignment3
    {
        static void Main()
        {
            //insert the input from the user
            Console.Write("Enter the number of terms (n): ");
            int n = int.Parse(Console.ReadLine());

            //initializing sum value

            int sum = 0;
            Console.WriteLine("The first " + n + " terms of square natural numbers are:");
            //using loop for setting range
            for (int i = 1; i <= n; i++)
            {
                int square = i * i;
                Console.Write(square + " ");
                sum += square;
            }
            //print
            Console.WriteLine();
            Console.WriteLine("The sum of the first " + n + " terms of square natural numbers is: " + sum);
        }
    }
}

