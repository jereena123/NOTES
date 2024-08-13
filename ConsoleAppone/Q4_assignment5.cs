using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q4_assignment5
    
    {
        static void Main()
        {
            // Input two strings
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();

            // Compare the strings
            bool areEqual = CompareStrings(str1, str2);

            // Display the result
            if (areEqual)
            {
                Console.WriteLine("The strings are equal.");
            }
            else
            {
                Console.WriteLine("The strings are not equal.");
            }
        }

        static bool CompareStrings(string s1, string s2)
        {
            // Check if lengths are different
            if (s1.Length != s2.Length)
            {
                return false;
            }

            // Compare each character
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }

}

