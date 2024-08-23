using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class MedicinePrescription
    {
        public int MedicinePrescriptionId { get; set; }
        public int Duration { get; set; }
        public string Dosage { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }
        public int MedicineId { get; set; }
        public int AppointmentId { get; set; }
    }

}
