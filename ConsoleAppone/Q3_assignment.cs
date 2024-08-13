using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q3_assignment
    {
        static void Main(string[] args)
        {


            // to loop between -5 to 5
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine("y is{0} and x={1}", y, x);
            }

        }
    }
}
