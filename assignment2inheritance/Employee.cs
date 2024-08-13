using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Text;

namespace assignment2inheritance
{
    public class Employee : Person
    {
        public decimal BasePay { get; set; }
        public decimal HR { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, int age, decimal basePay, decimal hr, decimal salary)
            : base(name, age)
        {
            BasePay = basePay;
            HR = hr;
            Salary = salary;
        }

        public override void DisplayDetails()
        {
            StringBuilder stringBuilder = new StringBuilder();
            base.DisplayDetails();
            stringBuilder.AppendLine($"Base Pay: {BasePay}");
            stringBuilder.AppendLine($"HR: {HR}");
            stringBuilder.AppendLine($"Salary: {Salary}");
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}



