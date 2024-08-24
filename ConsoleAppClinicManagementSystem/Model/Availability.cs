using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class Availability
    {
        public int AvailabilityId { get; set; }
        public int StaffId { get; set; }
        public bool IsActive { get; set; }

        public Availability() { }
        public Availability(int availabilityId, int staffId, bool isActive)
        {
            AvailabilityId = availabilityId;
            StaffId = staffId;
            IsActive = isActive;
        }
    }
}
