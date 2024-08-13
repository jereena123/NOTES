using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q1_assignment4
    
         {
        static void Main(string[] args)
        {
            // Declare variables
            int i;

            // Take input array size from user
            Console.WriteLine("Enter the size of the array you need to input:");
            int size = Convert.ToInt32(Console.ReadLine());

            // Initializing the array
            int[] arr = new int[size];

            // Take input array elements from user
            Console.WriteLine("Enter array elements:");

            // For loop to assign values to the array
            for (i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            // Print the array to display input
            Console.WriteLine("you entered :");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i]);
            }

            int duplicateCount = 0, j;

            // for loops to find duplicates
            for (i = 0; i < size; i++)
            {
                // Check if this element is already counted as a duplicate
                bool isDuplicate = false;
                for (j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                // If not counted before and has duplicates
                if (!isDuplicate)
                {
                    int count = 0;
                    for (j = 0; j < size; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }

                    if (count > 1)
                    {
                        duplicateCount++;
                    }
                }
            }

            // Print the number of duplicate elements
            Console.WriteLine($"Total number of duplicate elements: {duplicateCount}");


            Console.ReadKey();

        }
    }
}
