using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment5
{
    public class Apartment : Estate
    {
        public int Floor { get; set; }
        public bool HasElevator { get; set; }
        public bool IsFurnished { get; set; }

        public Apartment(double area, decimal pricePerSquareMeter, string location, int floor, bool hasElevator, bool isFurnished)
            : base(area, pricePerSquareMeter, location)
        {
            Floor = floor;
            HasElevator = hasElevator;
            IsFurnished = isFurnished;
        }

        public override string ToString()
        {
            return $"Apartment - {base.ToString()}, Floor: {Floor}, Elevator: {HasElevator}, Furnished: {IsFurnished}";
        }
    }
}
