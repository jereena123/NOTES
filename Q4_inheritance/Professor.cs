using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_inheritance
{
    public class Professor:Person

    {
        // Attributes
        private string name;
        private int empID;
        private string major;

        // Constructor
        public Professor(string name, int empID, string major)
        {
            this.name = name;
            this.empID = empID;
            this.major = major;
        }

        // Getters and Setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        // Method to simulate teaching
        public void Teach()
        {
            Console.WriteLine($"{name} is teaching.");
        }
    }

}
