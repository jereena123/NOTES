using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q11_assignment4
    
    {
        static void Main()
        {
            // Example list of integers
            List<int> numbers = new List<int> { 64, 34, 25, 12, 22, 11, 90 };

            Console.WriteLine("Original list:");
            PrintList(numbers);

            // Perform Bubble Sort
            BubbleSort(numbers);

            Console.WriteLine("\nSorted list:");
            PrintList(numbers);
        }

        static void BubbleSort(List<int> list)
        {
            int n = list.Count;
            bool swapped;

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        // Swap the elements
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                        swapped = true;
                    }
                }

                // If no two elements were swapped by the inner loop, then the list is sorted
                if (!swapped)
                    break;
            }
        }

        static void PrintList(List<int> list)
        {
            foreach (int number in list)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }

}
}
