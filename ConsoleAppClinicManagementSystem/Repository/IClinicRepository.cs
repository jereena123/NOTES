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
        void CreateAppointment(int patientId, int userId, int availabilityId, int staffId, out int appointmentId, out int tokenId);

        AppointmentDetails GetAppointmentDetails(int appointmentId);
        //Add patient method
        Task AddPatientAsync(Patient patient);

        //Update Patient
        Task<Patient> SearchPatientByIdAsync(int patientId);

        Task<Patient> SearchPatientByPhoneNumberAsync(string phoneNumber);
        Task UpdatePatientAsync(int patientId, string phoneNumber, string address);
        //Delete patient
        Task DeletePatientAsync(int PatientId);
        Task<int> PrescribeTestAsync(int appointmentId, int testId);
        Task PrescribeMedicinesAsync(int duration, string dosage, int quantity, string notes, int medicineId, int appointmentId);
        //search patient by id
        Task<Patient> SearchPatientById(int PatientId);

    }
}