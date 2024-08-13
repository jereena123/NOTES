using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment4
{
    public class Store
    {
        public List<AutoPart> PartsInventory { get; set; }

        public Store()
        {
            PartsInventory = new List<AutoPart>();
        }

        public void AddAutoPart(AutoPart autoPart)
        {
            PartsInventory.Add(autoPart);
        }

        public void DisplayInventory()
        {
            foreach (var part in PartsInventory)
            {
                Console.WriteLine(part);
                Console.WriteLine("Compatible Car Models:");
                foreach (var model in part.CompatibleCarModels)
                {
                    Console.WriteLine($"- {model}");
                }
                Console.WriteLine($"Manufactured by: {part.Manufacturer}\n");
            }
        }
    }

}
