using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q2_assignment2
    {
        static void Main(string[] args)
        {
            //initialize x and y
            int x = 0;
            int y = 0;

            //take input x and y from user
            Console.WriteLine("Enter x coordinate:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Y coordinate:");
            y = int.Parse(Console.ReadLine());

            //if loop to check which coordinate
            if ((x > 0) && (y > 0))
                Console.WriteLine("The coordinates belong to First Quadrant");
            else if ((x < 0) && (y > 0))
                Console.WriteLine("The coordinates belong to Second Quadrant");
            else if ((x < 0) && (y < 0))
                Console.WriteLine("The coordinates belong to Third Quadrant");
            else if ((x > 0) && (y < 0))
                Console.WriteLine("The coordinates belong to Fourth Quadrant");


            //pause screen
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
