using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q4_inheritance
{
    public class Professor : Person
    {
        public int EmpID { get; set; }
        public Major Major { get; set; }

        public Professor(string name, string id, int empID, Major major)
            : base(name, id)
        {
            EmpID = empID;
            Major = major;
        }

        // Method to simulate teaching
        public void Teach()
        {
            Console.WriteLine($"{Name} is teaching.");
        }
    }
}