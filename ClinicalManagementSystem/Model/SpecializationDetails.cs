using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class SpecializationDetails
    {
        public int SpecializationId { get; set; }
        public string SpecializationIn { get; set; }
        public decimal ConsultationFees { get; set; }
        public int StaffId { get; set; }
        public int QualificationId { get; set; }
        public int DepartmentId { get; set; }
    }

}
