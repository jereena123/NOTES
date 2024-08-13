using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q1_assignment6
  
    {
        static void Main()
        {
            // Input the string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Count spaces in the string
            int spaceCount = CountSpaces(input);

            // Display the result
            Console.WriteLine($"Number of spaces in the string: {spaceCount}");
        }

        static int CountSpaces(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == ' ')
                {
                    count++;
                }
            }
            return count;
        }
    }

}
}
