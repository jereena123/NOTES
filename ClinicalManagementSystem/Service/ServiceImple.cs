using ClinicalManagementSystem.Repository;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Service
{
    public class ServiceImple : IService
    {
        private readonly IClinicRepository _clinicRepository;

        // Constructor Injection
        public ServiceImple(IClinicRepository clinicRepository)
        {
            _clinicRepository = clinicRepository;
        }

        public async Task<(int StaffId, int RoleId)> AuthenticateUserAsync(string username, string password)
        {
            // Now returns a tuple containing both StaffId and RoleId
            return await _clinicRepository.GetRoleIdAsync(public async Task<bool> CheckPatientExistsAsync(string name, string phoneNumber)
            {
                return await _clinicRepository.CheckPatientExistsAsync(name, phoneNumber);
            }

            public async Task AddPatientAsync(Patient patient)
            {
                await _clinicRepository.AddPatientAsync(patient);
            }

            public async Task<Patient> GetPatientByNameAndPhoneAsync(string name, string phoneNumber)
            {
                return await _clinicRepository.GetPatientByNameAndPhoneAsync(name, phoneNumber);
            }

            public async Task<Patient> GetPatientByIdAsync(int patientId)
            {
                return await _clinicRepository.GetPatientByIdAsync(patientId);
            }

            public async Task UpdatePatientAsync(Patient patient)
            {
                await _clinicRepository.UpdatePatientAsync(patient);
            }

            public async Task DeletePatientAsync(int patientId)
            {
                await _clinicRepository.DeletePatientAsync(patientId);
            }
        }
}
