using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q5_assignment2
    {
        public static void Main(string[] args)
        {
            // Menus for user 

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");

            //get input for First Number
            Console.Write("Enter the First Number :");
            int firstNumber = int.Parse(Console.ReadLine());


            //get input for Second Number
            Console.Write("Enter the Second Number :");
            int secondNumber = int.Parse(Console.ReadLine());

            //choice
            Console.Write("Enter your choice :");
            int choice = int.Parse(Console.ReadLine());

            // check the condition
            if (choice == 1)
            {
                int Addition = firstNumber + secondNumber;
                Console.WriteLine("Addition of two numbers is =" + Addition);
            }
            else if (choice == 2)
            {
                int Subraction = firstNumber - secondNumber;
                Console.WriteLine("Subraction of two numbers is =" + Subraction);

            }
            else if (choice == 3)
            {
                int Multiplication = firstNumber * secondNumber;
                Console.WriteLine("Multiplication of two numbers is =" + Multiplication);
            }
            else if (choice == 4)
            {
                int Division = firstNumber / secondNumber;
                Console.WriteLine("Division of two numbers is =" + Division);
            }
        }
    }
}
