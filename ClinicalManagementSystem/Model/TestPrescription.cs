using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class TestPrescription
    {
        public int TestPrescriptionId { get; set; }
        public int AppointmentId { get; set; }
        public int TestId { get; set; }
    }

}
