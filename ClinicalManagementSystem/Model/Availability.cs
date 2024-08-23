using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class Availability
    {
        public int AvailabilityId { get; set; }
        public bool? IsActive { get; set; }
        public int StaffId { get; set; }
    }

}
