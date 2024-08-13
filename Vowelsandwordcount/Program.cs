using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowelsandwordcount
{
    internal class Program
    {
        static void Main()
        {
            FileOperation fileOp = new FileOperation();

            // Example usage of search operation
            string searchWord = "Jereena";
            int occurrences = fileOp.search(searchWord);
            Console.WriteLine($"Occurrences of '{searchWord}' in the file: {occurrences}");

            // Example usage of vowel count operation
            int[] vowelFrequency = fileOp.vowelCount();
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("\nVowel frequencies:");
            for (int i = 0; i < vowelFrequency.Length; i++)
            {
                Console.WriteLine($"'{vowels[i]}': {vowelFrequency[i]}");
            }
        }
    }
}
