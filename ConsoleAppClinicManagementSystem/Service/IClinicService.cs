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
        void BookAppointment(int patientId, int userId, int availabilityId, int staffId, out int appointmentId, out int tokenId);
        Task<Patient> SearchPatientByIdAsync(int patientId);
        Task<Patient> SearchPatientByPhoneNumberAsync(string phoneNumber);
        Task DeletePatientAsync(int patientId);
        Task AddPatientAsync(Patient patient);
        Task UpdatePatientAsync(int patientId, string phoneNumber, string address);
        Task<int> PrescribeTestAsync(int appointmentId, int testId);
        Task PrescribeMedicinesAsync(int duration, string dosage, int quantity, string notes, int medicineId, int appointmentId);
        AppointmentDetails GetAppointmentDetails(int appointmentId);


    }
}
    
