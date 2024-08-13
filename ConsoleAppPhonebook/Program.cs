using ConsoleAppPhonebook.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleAppPhonebook
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Open and read the file
            string filePath = "phone" +
                ".txt";

            // Store phone details
            List<Person> people = new List<Person>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    // Judes Abisha,Los Angeles,6374962072
                    string[] words = line.Split(',');

                    // [0] = Judes Abisha [1] = Los Angeles [2] = 6374962072
                    // Add it to list
                    people.Add(new Person(words[0], words[1], words[2]));
                }

                // Sort by city and then by name
                var sortedPeople = people.OrderBy(p => p.City).ThenBy(p => p.Name);

                // Print
                string currentCity = string.Empty;
                foreach (Person person in sortedPeople)
                {
                    if (person.City != currentCity)
                    {
                        if (!string.IsNullOrEmpty(currentCity))
                        {
                            Console.WriteLine();
                        }
                        Console.WriteLine($"{person.City} : ");
                        currentCity = person.City;
                    }
                    // Print Name
                    Console.WriteLine($"\t{person.Name}: {person.PhoneNumber}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
