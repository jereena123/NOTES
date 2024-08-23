using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Service
{
    public interface IService
    {
        Task<(int StaffId, int RoleId)> AuthenticateUserAsync(string username, string password);
        Task<bool> CheckPatientExistsAsync(string firstName, string lastName, string phoneNumber);
        Task AddPatientAsync(Patient patient);
        Task<Patient> GetPatientByNameAndPhoneAsync(string firstName, string lastName, string phoneNumber);
        Task<Patient> GetPatientByIdAsync(int patientId);
        Task UpdatePatientAsync(Patient patient);
        Task DeletePatientAsync(int patientId);
    }
}
