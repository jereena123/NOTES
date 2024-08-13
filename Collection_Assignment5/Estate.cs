using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment5
{
    public abstract class Estate
    {
        public double Area { get; set; } // Area in square meters
        public decimal PricePerSquareMeter { get; set; }
        public string Location { get; set; }

        public Estate(double area, decimal pricePerSquareMeter, string location)
        {
            Area = area;
            PricePerSquareMeter = pricePerSquareMeter;
            Location = location;
        }

        public decimal TotalPrice => (decimal)Area * PricePerSquareMeter;

        public override string ToString()
        {
            return $"Area: {Area} sqm, Price per sqm: {PricePerSquareMeter:C}, Location: {Location}, Total Price: {TotalPrice:C}";
        }
    }

}
