using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q6_assignment5
    {

        class Program
        {
            static void Main()
            {
                // Input string
                Console.WriteLine("Enter the main string:");
                string mainString = Console.ReadLine();

                // Start index and length for the substring
                Console.WriteLine("Enter the start index:");
                int startIndex = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the length of the substring:");
                int length = int.Parse(Console.ReadLine());

                // Extract the substring
                string result = ExtractSubstring(mainString, startIndex, length);

                // Display the result
                Console.WriteLine($"Extracted substring: {result}");
            }

            static string ExtractSubstring(string str, int startIndex, int length)
            {
                // Check for valid input
                if (startIndex < 0 || startIndex >= str.Length || length < 0)
                {
                    return string.Empty;
                }

                char[] substring = new char[length];
                int index = 0;

                for (int i = startIndex; i < startIndex + length && i < str.Length; i++)
                {
                    substring[index++] = str[i];
                }

                return new string(substring);
            }
        }

    }
}
