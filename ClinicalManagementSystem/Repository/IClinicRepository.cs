using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Repository
{
    public interface IClinicRepository
    {
        Task<(int StaffId, int RoleId)> GetRoleIdAsync(string userName, string password);
       
        Task AddPatientAsync(Patient patient);
        Task<Patient> GetPatientByNameAndPhoneAsync(string Name, string phoneNumber);
        Task<Patient> GetPatientByIdAsync(int patientId);
        Task<bool> CheckPatientExistsAsync(string Name, string phoneNumber);
        Task UpdatePatientAsync(Patient patient);
        Task DeletePatientAsync(int patientId);
    }
}
