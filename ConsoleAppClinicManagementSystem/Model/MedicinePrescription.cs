using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
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

        public MedicinePrescription() { }

        public MedicinePrescription(int medicinePrescriptionId, int duration, string dosage, int quantity, string notes, int medicineId, int appointmentId)
        {
            MedicinePrescriptionId = medicinePrescriptionId;
            Duration = duration;
            Dosage = dosage;
            Quantity = quantity;
            Notes = notes;
            MedicineId = medicineId;
            AppointmentId = appointmentId;
        }
    }
}
    
