using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public int PatientId { get; set; }
        public int StaffId { get; set; }
        public int TokenId { get; set; }

        public Appointment() { }

        public Appointment(int appointmentId, int userId, int patientId, int staffId, int tokenId)
        {
            AppointmentId = appointmentId;
            UserId = userId;
            PatientId = patientId;
            StaffId = staffId;
            TokenId = tokenId;
        }
    }

}
    