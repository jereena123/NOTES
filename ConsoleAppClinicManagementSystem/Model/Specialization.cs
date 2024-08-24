using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class Specialization
    {
        public int SpecializationId { get; set; }
        public string SpecializationIn { get; set; }
        public int ConsultationFees { get; set; }
        public int StaffId { get; set; }
        public int DepartmentId { get; set; }
        public int AvailabilityId { get; set; }
        public int QualificationId { get; set; }

        public Specialization() { }
        public Specialization(int specializationId, string specializationIn, int consultationFees, int staffId, int departmentId, int availabilityId, int qualificationId)
        {
            SpecializationId = specializationId;
            SpecializationIn = specializationIn;
            ConsultationFees = consultationFees;
            StaffId = staffId;
            DepartmentId = departmentId;
            AvailabilityId = availabilityId;
            QualificationId = qualificationId;
        }
    }
}
