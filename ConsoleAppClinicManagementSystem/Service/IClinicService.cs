using ConsoleAppClinicManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Service
{
    public interface IClinicService
    {
        //Authentication
        Task<(int StaffId, int RoleId)> AuthenticateUserAsync(string username, string password);
        Task AddPatientAsync(Patient patient);
        Task UpdatePatientAsync(Patient patient);

    }
}
