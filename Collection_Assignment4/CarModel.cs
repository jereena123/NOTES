using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment4
{
    public class CarModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public CarModel(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Brand} {Model}, {Year}";
        }
    }
}
