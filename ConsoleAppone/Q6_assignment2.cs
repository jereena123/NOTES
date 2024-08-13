using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q6_assignment2
    {
        public static void Main(string[] args)
        {
            //displaying menu to the User
            Console.WriteLine("Press 1 to Find the Area of Square");
            Console.WriteLine("Press 2 to Find the Area of Recatangle");
            Console.WriteLine("Press 3 to Find the Area of Traingle");

            //choice for the user
            Console.Write("Enter Your choice :");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                //getting the side from the user
                Console.Write("Enter the side of the Square :");
                int side = int.Parse(Console.ReadLine());

                //calculating the area of the squrae
                int square = side * side;

                Console.WriteLine("Area of the Square is = " + square);
            }
            else if (choice == 2)
            {
                //getting the length of the rectangle
                Console.Write("Enter the Length of the Rectangle :");
                double length = int.Parse(Console.ReadLine());

                //getting the breadth of the rectangle
                Console.Write("Enter the Breadth of the Recatangle :");
                double breadth = int.Parse(Console.ReadLine());

                //calculating area of rectangle
                double AreaOfRectangle = length * breadth;

                Console.WriteLine("Area of Rectangle is = " + AreaOfRectangle);

            }
            else if (choice == 3)
            {
                // input from user for breadth
                Console.Write("Enter the Breadth of the Traingle :");
                double breadth = int.Parse(Console.ReadLine());

                // input from user for height
                Console.Write("Enter the Height of the Traingle :");
                double height = int.Parse(Console.ReadLine());

                // calculating area
                double AreaofTraingle = (0.5 * breadth * height);

                Console.WriteLine("Area of the Traingle is =" + AreaofTraingle);
            }
        }
    }
}