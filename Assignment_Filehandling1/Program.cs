using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Filehandling1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "data.txt";
            string newText = "hi how are you";

            // Append text to file
            AppendToFile(filePath, newText);

            // Example of reading the file in read-only mode
            ReadFromFile(filePath);
        }

        static void AppendToFile(string filePath, string text)
        {
            // Append text to file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(text);
            }
        }

        static void ReadFromFile(string filePath)
        {
            // Open file in read-only mode with shared read access
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (StreamReader reader = new StreamReader(fs))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line); 
                    }
                }
            }
        }
    }
}
