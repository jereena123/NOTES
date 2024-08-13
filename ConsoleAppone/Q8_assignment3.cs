using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q8_assignment3
    {
        public static void Main()  
        {
            int i, sum = 0;  // Declaration of variables: 'i' for looping, 'sum' for storing the sum

          
            Console.Write("Find the number and sum of all integers between 100 and 200, divisible by 9:\n");  // Displaying the purpose of the program
          
            Console.Write("Numbers between 100 and 200, divisible by 9 : \n");  // Displaying the range of numbers
            for (i = 101; i < 200; i++)  // Loop through the range from 101 to 199
            {
                if (i % 9 == 0)  // Checking if the number is divisible by 9
                {
                    Console.Write("{0}  ", i);  // Displaying the number divisible by 9
                    sum += i;  // Adding the number to the 'sum' variable
                }
            }
            Console.Write("\n\nThe sum : {0} \n", sum);  
        }
    }
}
