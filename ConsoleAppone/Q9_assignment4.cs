using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q9_assignment4
    { 
        static void Main()
        {
            // Define the size of the matrices
            int size = 3;

            // Initialize two square matrices
            int[,] matrix1 = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            int[,] matrix2 = {
            { 9, 8, 7 },
            { 6, 5, 4 },
            { 3, 2, 1 }
        };

            // Create a result matrix to store the product
            int[,] productMatrix = new int[size, size];

            // Multiply the two matrices
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    productMatrix[i, j] = 0;
                    for (int k = 0; k < size; k++)
                    {
                        productMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            // Display the result matrix
            Console.WriteLine("Product of the matrices:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(productMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

}
}
