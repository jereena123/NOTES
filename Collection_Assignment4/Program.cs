using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Create manufacturing companies
                var manufacturer1 = new ManufacturingCompany("HONDA", "INDIA", "MELPURAM", "8765322111", "43113445");
                var manufacturer2 = new ManufacturingCompany("VOLKWAGEN", "INDIA", "MARTHANDAM City", "96789095", "3245789999");

                // Create car models
                var carModel1 = new CarModel("Mercedes", "CRG", 2000);
                var carModel2 = new CarModel("BMW", "X5", 2010);
                var carModel3 = new CarModel("Toyota", "CGH", 2000);

                // Create auto parts
                var part1 = new AutoPart("O1", "SK", "TRAINING KIT", 250.00m, 400.00m, manufacturer1);
                part1.AddCompatibleCarModel(carModel1);
                part1.AddCompatibleCarModel(carModel2);

                var part2 = new AutoPart("P002", "Tire", "Tires and Wheels", 150.00m, 250.00m, manufacturer2);
                part2.AddCompatibleCarModel(carModel2);
                part2.AddCompatibleCarModel(carModel3);

                // Create a store and add parts to inventory
                var autoPartsStore = new Store();
                autoPartsStore.AddAutoPart(part1);
                autoPartsStore.AddAutoPart(part2);

                // Display the inventory
                Console.WriteLine("Auto Parts Inventory:");
                autoPartsStore.DisplayInventory();
                Console.ReadKey();
            }
        }
    }
}
