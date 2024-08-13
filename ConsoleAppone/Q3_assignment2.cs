
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q3_assignment2
    {
        static void Main(string[] args)
        {
            //initialize name,rollnumber,marks1,marks2,marks3
            string name;
            int rollNumber;
            double marks1, marks2, marks3;

            //input name
            Console.WriteLine("enter your name:");
            name = Console.ReadLine();

            //input rollnumber
            Console.WriteLine("enter your roll number:");
            rollNumber = int.Parse(Console.ReadLine());

            //input marks1
            Console.WriteLine("enter your marks1:");
            marks1 = double.Parse(Console.ReadLine());

            //input marks2
            Console.WriteLine("enter your marks2:");
            marks2 = double.Parse(Console.ReadLine());

            //input marks3
            Console.WriteLine("enter your marks3:");
            marks3 = double.Parse(Console.ReadLine());

            //calculate the total marks
            double total = marks1 + marks2 + marks3;
            Console.WriteLine("total marks is " + total);

            //calculate percentage
            double percentage = (total / 300) * 100;
            Console.WriteLine("percentage is " + percentage);

            //division
            if (percentage > 70)
            {
                Console.WriteLine("First Class");
            }
            else if ((percentage < 70) && (percentage > 60))
            {
                Console.WriteLine("Second Class");

            }
            else if ((percentage < 60) && (percentage > 50))
            {
                Console.WriteLine("Third Class");
            }
            else
            {
                Console.WriteLine("Fail");

            }

            //pause screen
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }

    }
}
