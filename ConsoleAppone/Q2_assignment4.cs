using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppone
{
    internal class Q2_assignment4
    {
        static void Main(string[] args)
        {

        

        int n;

        Console.WriteLine("Enter the number of elements:");
            n = int.Parse(Console.ReadLine());

        // Declaring array and getting the input from user
        int[] array = new int[n];
        Console.WriteLine($"Enter {n} elements separated by spaces:");

            // Array integers to string 
            string input = Console.ReadLine();

        // String to integers
        string[] elements = input.Split(' ');

            // Parse 
            for (int i = 0; i<n; i++)
            {
                array[i] = int.Parse(elements[i]);
    }

    Console.WriteLine("The elements in the array are:");

            for (int i = 0; i<n; i++)
            {
                Console.WriteLine(array[i]);
            }

// Initialize max and min variables
int max = array[0];
int min = array[0];

// Iterate through the array to find max and min elements
for (int i = 1; i < n; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }

    if (array[i] < min)
    {
        min = array[i];
    }
}

// Display the maximum and minimum elements
Console.WriteLine("The maximum element in the array is: " + max);
Console.WriteLine("The minimum element in the array is: " + min);

// Wait for user input before closing
Console.ReadKey();
        }
    }
}
