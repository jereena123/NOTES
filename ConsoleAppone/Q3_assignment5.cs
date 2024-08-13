using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q3_assignment5
    
    {
        static void Main()
        {
            // Input string
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            // Count the number of words
            int wordCount = CountWords(input);

            // Display the result
            Console.WriteLine($"Total number of words: {wordCount}");
        }

        static int CountWords(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
            {
                return 0;
            }

            // Split the string by whitespace and count the elements
            string[] words = str.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }

}
}
