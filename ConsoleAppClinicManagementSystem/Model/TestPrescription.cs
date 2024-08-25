using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class TestPrescription
    {
        public int TestPrescriptionId { get; set; }
        public int AppointmentId { get; set; }
        public int TestId { get; set; }
        public TestPrescription() { }
        public TestPrescription(int testPrescriptionId, int appointmentId, int testId)
        {
            TestPrescriptionId = testPrescriptionId;
            AppointmentId = appointmentId;
            TestId = testId;
        }
    }
}
