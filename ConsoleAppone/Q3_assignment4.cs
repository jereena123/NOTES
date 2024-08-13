using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q3_assignment4
    {
        public static void Main()
        {
            // Declare arrays to hold integers
            int[] arr1 = new int[10];  // First array to store user input
            int[] arr2 = new int[10];  // Array to store even integers
            int[] arr3 = new int[10];  // Array to store odd integers
            int i, j = 0, k = 0, n;    // Declare variables for counting and user input

            
            Console.Write("\n\nSeparate odd and even integers in separate arrays:\n");
           

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine()); // Read the number of elements entered by the user

            // Prompt the user to input 'n' elements in the array
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine()); // Store user input in the first array
            }

            // Iterate through the first array to separate even and odd numbers into separate arrays
            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0) // Check if the number is even
                {
                    arr2[j] = arr1[i]; // Store even number in the second array
                    j++; // Increment the counter for the even array
                }
                else
                {
                    arr3[k] = arr1[i]; // Store odd number in the third array
                    k++; // Increment the counter for the odd array
                }
            }

            // Display even elements stored in the second array
            Console.Write("\nThe Even elements are : \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]); // Print even numbers
            }

            // Display odd elements stored in the third array
            Console.Write("\nThe Odd elements are :\n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]); // Print odd numbers
            }
            Console.Write("\n\n"); // Print a new line for formatting
        }
    }
}
