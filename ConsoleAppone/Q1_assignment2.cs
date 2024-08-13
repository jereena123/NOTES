using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q1_assignment2
    {
        static void Main(string[] args)
        {
            //initialize age
            int age = 0;

            //take input from user
            Console.Write("Enter your age :");
            age = int.Parse(Console.ReadLine());

            //if loop for checking age 
            if (age >= 18)
            {
                Console.WriteLine("Eligible to vote");
            }
            else
            {
                Console.WriteLine("Not eligible to vote");
            }
            //pause screen
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
