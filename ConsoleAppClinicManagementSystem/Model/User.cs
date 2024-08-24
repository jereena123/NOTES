using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int StaffId { get; set; }
        public User() { }
        public User(int userId, string userName, string password, bool isActive, int staffId)
        {
            UserId = userId;
            UserName = userName;
            Password = password;
            IsActive = isActive;
            StaffId = staffId;
        }
    }
}
