using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment5
{
    public class House : Estate
    {
        public double DevelopedArea { get; set; }
        public double UndevelopedArea { get; set; }
        public int Floors { get; set; }
        public bool IsFurnished { get; set; }

        public House(double area, decimal pricePerSquareMeter, string location, double developedArea, double undevelopedArea, int floors, bool isFurnished)
            : base(area, pricePerSquareMeter, location)
        {
            DevelopedArea = developedArea;
            UndevelopedArea = undevelopedArea;
            Floors = floors;
            IsFurnished = isFurnished;
        }

        public override string ToString()
        {
            return $"House - {base.ToString()}, Developed Area: {DevelopedArea} sqm, Undeveloped Area: {UndevelopedArea} sqm, Floors: {Floors}, Furnished: {IsFurnished}";
        }
    }

    }

