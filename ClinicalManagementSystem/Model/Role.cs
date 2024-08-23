using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class Role
    {
        //fields
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsActived { get; set; }
    }
}
