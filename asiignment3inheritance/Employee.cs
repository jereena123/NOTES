using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asiignment3inheritance
{
    public class Employee
    {
        public int EmployeeNo { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal BasicPay { get; set; }

        public Employee(int employeeNo, string name, string designation, decimal basicPay)
        {
            EmployeeNo = employeeNo;
            Name = name;
            Designation = designation;
            BasicPay = basicPay;
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Employee No: {EmployeeNo}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Designation: {Designation}");
            Console.WriteLine($"Basic Pay: Rs.{BasicPay}");
        }
    }
}
