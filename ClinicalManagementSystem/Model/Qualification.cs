using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class Qualification
    {
        public int QualificationId { get; set; }
        public string QualificationName { get; set; }
        public int RoleId { get; set; }
    }
}
