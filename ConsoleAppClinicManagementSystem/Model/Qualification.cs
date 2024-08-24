using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class Qualification
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public int RoleId { get; set; }

        public Qualification() { }

        public Qualification(int qualificationId, string qualificationName, int roleId)
        {
            QualificationId = qualificationId;
            QualificationName = qualificationName;
            RoleId = roleId;
        }
    }
}
