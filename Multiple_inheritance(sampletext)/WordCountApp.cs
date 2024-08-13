using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Multiple_inheritance_sampletext_
{
    public class WordCountApp
    {
        static void Main(string[] args)
        {
            // Select file
            string filePath = "demo.txt";

            // Check file exists
            if (File.Exists(filePath))
            {
                // Read all the contents
                string content = File.ReadAllText(filePath);

                // Split the contents
                string[] words = content.Split(new char[] { ' ', '\r', '\n', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                // Printing the word count
                Console.WriteLine("Word count: " + words.Length);

                // Create a dictionary to store word counts
                Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

                // Count the occurrence of each word
                foreach (string word in words)
                {
                    string lowerWord = word.ToLower();
                    if (wordCount.ContainsKey(lowerWord))
                    {
                        // Increment the count for the word
                        wordCount[lowerWord]++;
                    }
                    else
                    {
                        // Initialize the count for the word
                        wordCount[lowerWord] = 1;
                    }
                }

                // Order the result by number of occurrences
                var orderedWordCount = wordCount.OrderByDescending(x => x.Value);

                // Print the word occurrences
                foreach (var kvp in orderedWordCount)
                {
                    Console.WriteLine($"{kvp.Key} ==> {kvp.Value}");
                }
            }
            else
            {
                // Print if file does not exist
                Console.WriteLine($"File '{filePath}' does not exist.");
            }

            Console.ReadKey();
        }
    }
}
