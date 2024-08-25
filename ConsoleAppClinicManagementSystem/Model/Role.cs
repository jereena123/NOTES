using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class Role
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsActived { get; set; }

        public Role() { }
        public Role(int roleId, string roleName, bool isActived)
        {
            RoleId = roleId;
            RoleName = roleName;
            IsActived = isActived;
        }
 
    }
}
