using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class TestBill
    {
        public int TestBillId { get; set; }
        public decimal TotalTestBill { get; set; }
        public DateTime Date { get; set; }
        public int TestPrescriptionId { get; set; }

        public TestBill() { }
        public TestBill(int testBillId, decimal totalTestBill, DateTime date, int testPrescriptionId)
        {
            TestBillId = testBillId;
            TotalTestBill = totalTestBill;
            Date = date;
            TestPrescriptionId = testPrescriptionId;
        }
    }
}
