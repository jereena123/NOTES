using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellphoneapp
{
    public abstract class Account
    {
        public string CellphoneNumber { get; set; }
        public int TotalCallTime { get; set; }
        public decimal TotalCostOfCalls { get; set; }

        protected Account(string cellphoneNumber, int totalCallTime, decimal totalCostOfCalls)
        {
            CellphoneNumber = cellphoneNumber;
            TotalCallTime = totalCallTime;
            TotalCostOfCalls = totalCostOfCalls;
        }

        public override string ToString()
        {
            return $"Cellphone Number: {CellphoneNumber}, Total Call Time: {TotalCallTime} mins, Total Cost: {TotalCostOfCalls:C}";
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
