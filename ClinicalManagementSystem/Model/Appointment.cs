using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int StaffId { get; set; }
        public int AvailabilityId { get; set; }
        public int PatientId { get; set; }
        public int UserId { get; set; }
        public int TokenId { get; set; }
    }

}
