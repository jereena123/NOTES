using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q2_assignment6
    
    {
        static void Main()
        {
            // Define an example array
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Calculate the sum of elements
            int sum = CalculateSum(numbers);

            // Display the result
            Console.WriteLine($"The sum of the elements in the array is: {sum}");
        }

        static int CalculateSum(int[] array)
        {
            int sum = 0;

            // Iterate through each element and accumulate the sum
            foreach (int number in array)
            {
                sum += number;
            }

            return sum;
        }
    }

}
}
