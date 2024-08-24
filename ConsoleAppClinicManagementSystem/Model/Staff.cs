using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; }
        public int QualificationId { get; set; }

        public Staff() { }
        public Staff(int staffId, string staffName, DateTime dOB, string gender, string bloodGroup, int phoneNumber, string address, bool isActive, int roleId, int qualificationId)
        {
            StaffId = staffId;
            StaffName = staffName;
            DOB = dOB;
            Gender = gender;
            BloodGroup = bloodGroup;
            PhoneNumber = phoneNumber;
            Address = address;
            IsActive = isActive;
            RoleId = roleId;
            QualificationId = qualificationId;
        }
    }
}
