using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public int StaffContact { get; set; }
        public DateTime StaffDOB { get; set; }
        public string StaffGender { get; set; }
        public string StaffBloodGroup { get; set; }
        public string StaffAddress { get; set; }
        public bool? IsActive { get; set; }
        public int QualificationId { get; set; }
        public int RoleId { get; set; }
    }

}
