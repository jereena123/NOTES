using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q7_assignment4
    { 

        static void Main()
        {
            // Example array
            int[] array = { 12, 3, 5, 7, 19, 1, 10 };

            // Function to find the second smallest element
            int secondSmallest = FindSecondSmallest(array);

            if (secondSmallest == int.MaxValue)
            {
                Console.WriteLine("There is no second smallest element in the array.");
            }
            else
            {
                Console.WriteLine("The second smallest element is: " + secondSmallest);
            }
        }

        static int FindSecondSmallest(int[] array)
        {
            if (array == null || array.Length < 2)
            {
                return int.MaxValue; // Not enough elements
            }

            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int number in array)
            {
                if (number < smallest)
                {
                    secondSmallest = smallest;
                    smallest = number;
                }
                else if (number < secondSmallest && number != smallest)
                {
                    secondSmallest = number;
                }
            }

            return secondSmallest;
        }
    }

}

