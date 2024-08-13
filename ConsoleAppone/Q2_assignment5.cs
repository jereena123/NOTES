using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q2_assignment5
    {
        public static void Main()  
        {
            string str, str1 = "";  // Declaration of string variables
            int i, l;  // Declaration of integer variables

            Console.Write("\n\n");
            Console.Write("Print a string in reverse order:\n");
           

            Console.Write("Input a String: ");
            str = Console.ReadLine();  // Taking user input for a string

            l = str.Length - 1;  // Finding the length of the string

            // Loop to reverse the given string
            for (i = l; i >= 0; i--)
            {
                str1 = str1 + str[i];  //creating the reversed string
            }

            // Displaying the reversed string
            Console.WriteLine("The string in Reverse Order Is: {0}", str1);
            Console.Write("\n");
        }
    }
}
