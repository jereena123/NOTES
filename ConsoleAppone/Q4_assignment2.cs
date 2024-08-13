using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q4_assignment2
    {
        public static void Main(string[] args)
        {
            //get input for Maths mark
            Console.Write("Enter your maths mark :");
            int mathsmarks = int.Parse(Console.ReadLine());


            //get input for Physics mark
            Console.Write("Enter your Physics mark :");
            int physicsmarks = int.Parse(Console.ReadLine());

            //get input for Chemistry mark
            Console.Write("Enter your Chemistry mark :");
            int chemistrymarks = int.Parse(Console.ReadLine());

            //calculating total marks
            int total = mathsmarks + physicsmarks + chemistrymarks;


            //check the condition
            if (total >= 180 && mathsmarks >= 65 && physicsmarks >= 55 && chemistrymarks >= 50)
            {
                Console.WriteLine("Your Eligible for Proffessional course");

            }
            else if (mathsmarks >= 65 && total >= 140)
            {
                Console.WriteLine("Your Eligible for the Professional course");
            }
            else
            {
                Console.WriteLine("Your are Not Eligible for the Professional course ");
            }
        }
    }
}
