using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class Bill
    {
        public int BillId { get; set; }
        public decimal GrandTotalAmount { get; set; }
        public DateTime Date { get; set; }
        public int MedicineBillId { get; set; }
        public int TestBillId { get; set; }
        public int SpecializationId { get; set; }
    }

}
