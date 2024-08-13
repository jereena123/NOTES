
using System;

class DiamondPattern
{
    static void Main()
    {
        int n = 5; // Number of rows for the upper half 
        PrintDiamond(n);
    }

    static void PrintDiamond(int n)
    {
        // Print the upper half of the diamond
        for (int i = 1; i <= n; i++)
        {
            // Print spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            // Print stars
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Print the lower half of the diamond
        for (int i = n - 1; i >= 1; i--)
        {
            // Print spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }
            // Print stars
            for (int j = 1; j <= 2 * i - 1; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}