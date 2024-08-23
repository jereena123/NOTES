using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class MedicineBill
    {
        public int MedicineBillId { get; set; }
        public decimal TotalMedicineBill { get; set; }
        public DateTime Date { get; set; }
        public int MedicinePrescriptionId { get; set; }
    }

}
