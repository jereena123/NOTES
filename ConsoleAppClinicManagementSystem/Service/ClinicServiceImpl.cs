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
        private readonly IClinicRepository _appointmentRepository;

        public ClinicServiceImpl(IClinicRepository clinicalRepository, IClinicRepository appointmentRepository)
        {
            _clinicalRepository = clinicalRepository;
            _appointmentRepository = appointmentRepository;
        }

        public async Task AddPatientAsync(Patient patient)
        {
            await _clinicalRepository.AddPatientAsync(patient);
        }

        public async Task<(int StaffId, int RoleId)> AuthenticateUserAsync(string userName, string password)
        {
            return await _clinicalRepository.GetStaffIdAndRoleIdAsync(userName, password);
        }

        public void BookAppointment(int patientId, int userId, int availabilityId, int staffId, out int appointmentId, out int tokenId)
        {
            _clinicalRepository.CreateAppointment(patientId, userId, availabilityId, staffId, out appointmentId, out tokenId);
        }

        public async Task DeletePatientAsync(int patientId)
        {
            await _clinicalRepository.DeletePatientAsync(patientId);
        }

        public AppointmentDetails GetAppointmentDetails(int appointmentId)
        {
            return _appointmentRepository.GetAppointmentDetails(appointmentId);
        }

       
        public async Task  PrescribeMedicinesAsync(int duration, string dosage, int quantity, string notes, int medicineId, int appointmentId)
        {
           await _clinicalRepository.PrescribeMedicinesAsync(duration, dosage, quantity, notes, medicineId, appointmentId);
        }

        public async Task<int> PrescribeTestAsync(int appointmentId, int testId)
        {
            return await _clinicalRepository.PrescribeTestAsync(appointmentId, testId);
        }

        public async Task<Patient> SearchPatientByIdAsync(int patientId)
        {
            return await _clinicalRepository.SearchPatientByIdAsync(patientId);
        }

        public async Task<Patient> SearchPatientByPhoneNumberAsync(string phoneNumber)
        {
            return await _clinicalRepository.SearchPatientByPhoneNumberAsync(phoneNumber);
        }

        public async Task UpdatePatientAsync(int patientId, string phoneNumber, string address)
        {
            await _clinicalRepository.UpdatePatientAsync(patientId, phoneNumber, address);
        }
    }
}










