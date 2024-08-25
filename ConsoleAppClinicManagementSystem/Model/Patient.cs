using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        
        public string Bloodgroup { get; set; }
        public string Address { get; set; }

        public Patient()
        {

        }
        public Patient(int patientId, string patientName, DateTime dOB, string gender, string phoneNumber, string bloodGroup, string address)
        {
            PatientId = patientId;
            PatientName = patientName;
            DOB = dOB;
            Gender = gender;
            PhoneNumber = phoneNumber;
            
            Bloodgroup = bloodGroup;
            Address = address;
        }
    }
}
    
