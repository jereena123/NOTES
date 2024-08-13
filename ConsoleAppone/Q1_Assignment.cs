using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q1_Assignment

    {
        static void Main(string[] args)

        {

            //input length and height 
            double length = 0;
            double height = 0;
            Console.Write("Enter the length:");

            //parse legth
            length = double.Parse(Console.ReadLine());
            Console.Write("Enter the height:");

            //parse height
            height = double.Parse(Console.ReadLine());
            double area = 0.5 * length * height;

            // area of the triangle
            Console.WriteLine("area is " + area);

            //pause a screen
            Console.ReadKey();
        }

    }

}