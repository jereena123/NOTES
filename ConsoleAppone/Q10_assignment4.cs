using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q10_assignment4
    { 
        static void Main()
        {
            // Define the size of the matrices
            int rows = 2;
            int cols = 3;

            // Create two matrices
            int[,] matrix1 = new int[rows, cols];
            int[,] matrix2 = new int[rows, cols];

            // Input for matrix1
            Console.WriteLine("Enter elements for Matrix 1:");
            ReadMatrix(matrix1, rows, cols);

            // Input for matrix2
            Console.WriteLine("Enter elements for Matrix 2:");
            ReadMatrix(matrix2, rows, cols);

            // Check if the matrices are equal
            bool areEqual = AreMatricesEqual(matrix1, matrix2, rows, cols);

            if (areEqual)
            {
                Console.WriteLine("The matrices are equal.");
            }
            else
            {
                Console.WriteLine("The matrices are not equal.");
            }
        }

        static void ReadMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static bool AreMatricesEqual(int[,] matrix1, int[,] matrix2, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }

}

