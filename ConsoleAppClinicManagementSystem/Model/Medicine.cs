using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class Medicine
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string MedicineType { get; set; }
        public decimal MedicineAmount { get; set; }

        public Medicine()
        {
        }
        public Medicine(int medicineId, string medicineName, string medicineType, decimal medicineAmount)
        {
            MedicineId = medicineId;
            MedicineName = medicineName;
            MedicineType = medicineType;
            MedicineAmount = medicineAmount;
        }
    }
}
    

