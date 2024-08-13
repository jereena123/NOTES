using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q8_assignment4
    { 
        static void Main()
        {
            // Define the size of the matrices
            int rows = 2;
            int cols = 3;

            // Initialize two matrices
            int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 }
        };

            int[,] matrix2 = {
            { 7, 8, 9 },
            { 10, 11, 12 }
        };

            // Create a result matrix to store the sum
            int[,] sumMatrix = new int[rows, cols];

            // Add the two matrices
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            // Display the result matrix
            Console.WriteLine("Sum of the matrices:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(sumMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}
}
