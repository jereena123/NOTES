using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q6_assignment4
    {
        public static void Main()
        {
            int i, pos, n; // Declare variables for counting, position, and array size
            int[] arr1 = new int[50]; // Declare an array to store integers

            
            Console.Write("\n\nDelete an element at desired position from an array :\n");
           

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine()); // Read the size of the array entered by the user

            /* Store values into the array */
            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine()); // Store user input in the array
            }

            Console.Write("\nInput the position where to delete: ");
            pos = Convert.ToInt32(Console.ReadLine()); // Read the position of the element to be deleted

            
            i = 0;
            while (i != pos - 1)
                i++; // Find the index position that needs to be deleted

            /* Replace the element at the position with its right neighbor */
            while (i < n)
            {
                arr1[i] = arr1[i + 1]; // Shift elements to the left to overwrite the element to be deleted
                i++;
            }
            n--; // Decrease the size of the array by one after deletion

            Console.Write("\nThe new list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]); // Display the updated array after deletion
            }
            Console.Write("\n\n");
        }
    }
}
}
