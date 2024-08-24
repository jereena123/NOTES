using ConsoleAppClinicManagementSystem.Model;
using ConsoleAppClinicManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Service
{
    public class ClinicServiceImpl : IClinicService
    
        {
            private readonly IClinicRepository _clinicalRepository;

            public ClinicServiceImpl(IClinicRepository clinicalRepository)
            {
                _clinicalRepository = clinicalRepository;
            }

        public async Task AddPatientAsync(Patient patient)
        {
            await _clinicalRepository.AddPatientAsync(patient);
        }

        
        

        public async Task<(int StaffId, int RoleId)> AuthenticateUserAsync(string userName, string password)
            {
                return await _clinicalRepository.GetStaffIdAndRoleIdAsync(userName, password);
            }

        public async Task UpdatePatientAsync(Patient patient)
        {
            if (patient == null)
            {
                throw new ArgumentNullException(nameof(patient));
            }

            
            await _clinicalRepository.UpdatePatientAsync(patient);
        }
    }


    }
