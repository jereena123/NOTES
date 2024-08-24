using ConsoleAppClinicManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Repository
{
    public interface IClinicRepository
    {
        Task<(int StaffId, int RoleId)> GetStaffIdAndRoleIdAsync(string userName, string password);
        //Add patient method
        Task AddPatientAsync(Patient patient);

        //Update Patient
        Task UpdatePatientAsync(Patient patient);

        //Delete patient
        Task DeletePatientAsync(int PatientId);

        //search patient by id
        Task<Patient> SearchPatientById(int PatientId);

    }
}
