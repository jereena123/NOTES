using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment5
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; } // Years of experience

        public Employee(string name, string position, int experience)
        {
            Name = name;
            Position = position;
            Experience = experience;
        }

        public override string ToString()
        {
            return $"{Name}, {Position}, {Experience} years experience";
        }
    }
}
