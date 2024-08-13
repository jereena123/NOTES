using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q1_assignment5
    {
        public static void Main()
        {
            string str; // Declare a string variable
            int l = 0; // Initialize a variable for length

            // Prompt the user to find the length of a string
            Console.Write("\n\nFind the length of a string:\n");
           

            // Request user input for a string
            Console.Write("Input the string: ");
            str = Console.ReadLine(); // Read the user input

            // Loop through each character in the string to calculate its length
            foreach (char chr in str)
            {
                l += 1; // Increment the length counter for each character encountered
            }

            // Display the length of the entered string
            Console.Write("Length of the string is: {0}\n\n", l);
        }
    }
}
