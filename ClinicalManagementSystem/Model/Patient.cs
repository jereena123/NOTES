using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public DateTime DOB { get; set; }
        public int PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Bloodgroup { get; set; }
    }

}
