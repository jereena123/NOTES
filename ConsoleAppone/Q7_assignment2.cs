using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q7_assignment2
    {
        public static void Main(string[] args)
        { 
            
            double unit, charge;
            Console.Write("Enter the customer id :");
            Console.ReadLine();
            Console.Write("Enter the customer name :");
            Console.ReadLine();
            Console.Write("Enter the unit :");
            unit = double.Parse(Console.ReadLine());

            if (unit <= 199)
            {
                charge = (unit * 1.20);
                Console.WriteLine("The payable amount is " + charge);
            }
            else if (unit > 200 && unit <= 400)
            {
                charge = (unit * 1.50);
                Console.WriteLine("The payable amount is " + charge);
            }
            else if (unit > 400 && unit <= 600)
            {
                charge = (unit * 1.80);
                Console.WriteLine("The payable amount is " + charge);
            }
            else
            {
                charge = (unit * 2.00);
                Console.WriteLine("The payable amount is " + charge);
            }
        }
    }
}
