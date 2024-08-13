using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Assignment5
{
    public class Company
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public string TaxID { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Estate> EstatesForSale { get; set; } = new List<Estate>();

        public Company(string name, string owner, string taxID)
        {
            Name = name;
            Owner = owner;
            TaxID = taxID;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void AddEstate(Estate estate)
        {
            EstatesForSale.Add(estate);
        }

        public void DisplayEstates()
        {
            EstatesForSale.ForEach(Console.WriteLine);
        }

        public void DisplayEmployees()
        {
            Employees.ForEach(Console.WriteLine);
        }
    }

}
