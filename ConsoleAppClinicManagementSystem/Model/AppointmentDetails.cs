using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class AppointmentDetails
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public int AvailabilityId { get; set; }
        public int TokenId { get; set; }
        public int TokenNumber { get; set; }
        public string TokenTime { get; set; }
        public DateTime TokenDate { get; set; }
    }
}
