using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Filehandling2
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "file.txt"; // Replace with the path to your file

            try
            {
                // Read  the file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string fileContent = reader.ReadToEnd();

                    // Starting from the 3rd character, we need at least 8 characters
                    if (fileContent.Length >= 8)
                    {
                        // Extract five characters starting from the third character
                        string r = fileContent.Substring(2, 5);

                        
                        Console.WriteLine("Extracted text: " + r);
                    }
                    else
                    {
                        Console.WriteLine("The file does not contain enough characters.");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
        }
