using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q3_assignment6
 
    {
        // Method to swap two integers using a temporary variable
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void Main()
        {
            int num1 = 5;
            int num2 = 10;

            Console.WriteLine($"Before swapping: num1 = {num1}, num2 = {num2}");

            // Calling the Swap method
            Swap(ref num1, ref num2);

            Console.WriteLine($"After swapping: num1 = {num1}, num2 = {num2}");
        }
    }

}
}
