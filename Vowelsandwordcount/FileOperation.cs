using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowelsandwordcount
{
    public class FileOperation : ISearchOperation, IVowelOperation
    {
        private string filePath = "phone.txt"; // Path to your phonebook text file

        // Method to search for a word and count its occurrences
        public int search(string word)
        {
            int count = 0;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Assuming search for a word in a line (e.g., name)
                        if (line.ToLower().Contains(word.ToLower()))
                        {
                            count++;
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file:");
                Console.WriteLine(e.Message);
            }
            return count;
        }

        // Method to calculate frequency of each vowel in the file
        public int[] vowelCount()
        {
            int[] frequency = new int[5]; // Array to hold counts of 'a', 'e', 'i', 'o', 'u'
            string vowels = "aeiou";

            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        foreach (char c in line.ToLower())
                        {
                            int index = vowels.IndexOf(c);
                            if (index >= 0)
                            {
                                frequency[index]++;
                            }
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file:");
                Console.WriteLine(e.Message);
            }
            return frequency;
        }
    }
}
