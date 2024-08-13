using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q2_assignment
    {
        static void Main(string[] args)
        {


            //input distance and time
            double distance = 0;
            double time = 0;
            Console.Write("Enter the distance:");

            //parse distance
            distance = double.Parse(Console.ReadLine());
            Console.Write("Enter the time:");

            //parse time
            time = double.Parse(Console.ReadLine());

            //calculate  speed in kilometer/hour
            double speedKmph = distance / time;

            // Convert speed in km/hr to miles/hr
            double speedMph = speedKmph / 1.60;


            //print output
            Console.WriteLine("speed in Kmph: " + speedKmph);
            Console.WriteLine("speed in Mph: " + speedMph);


            //pause a screen
            Console.ReadKey();
        }
    }
}
