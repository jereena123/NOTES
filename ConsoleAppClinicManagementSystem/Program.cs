using ConsoleAppClinicManagementSystem.Model;
using ConsoleAppClinicManagementSystem.Repository;
using ConsoleAppClinicManagementSystem.Service;
using ConsoleAppClinicManagementSystem.Utility;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CSHARPWINDOW"].ConnectionString;
            IClinicRepository clinicRepository = new ClinicRepositoryImpl(connectionString);
            IClinicService clinicalService = new ClinicServiceImpl(clinicRepository, clinicRepository);

            Console.WriteLine("-------------------------");
            Console.WriteLine("         L O G I N       ");
            Console.WriteLine("-------------------------");

            string userName;
            do
            {
                Console.Write("Enter Username: ");
                userName = Console.ReadLine();
            } while (!CustomValidation.IsValidUserName(userName));

            string password;
            do
            {
                Console.Write("Enter Password: ");
                password = CustomValidation.ReadPassword();
            } while (!CustomValidation.IsValidPassword(password));

            var (staffId, roleId) = await clinicalService.AuthenticateUserAsync(userName, password);

            if (staffId > 0)
            {
                Console.WriteLine($"Login successful. StaffId: {staffId}, RoleId: {roleId}");
                switch (roleId)
                {
                    case 1:
                        await GoToReceptionistDashboardAsync(clinicalService);
                        break;
                    case 2:
                        await GoToDoctorDashboardAsync(clinicalService);
                        break;
                    default:
                        Console.WriteLine("Invalid Role ID.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid credentials.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static async Task GoToReceptionistDashboardAsync(IClinicService clinicalService)
        {
            Console.WriteLine("\n--- Receptionist Dashboard ---");
            while (true)
            {
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Search by Id");
                Console.WriteLine("3. Search by phone");
                Console.WriteLine("4. Update Patient");
                Console.WriteLine("5. Delete Patient");
                Console.WriteLine("6.Book Appointment");
                Console.Write("Enter Your Choice: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5:");
                }

                switch (choice)
                {
                    case 1:
                        await AddPatientAsync(clinicalService);
                        break;
                    case 2:
                        await SearchByIdIdAsync(clinicalService);
                        break;
                    case 3:
                        await SearchByphoneAsync(clinicalService);
                        break;
                    case 4:
                        await UpdatePatientAsync(clinicalService);
                        break;


                    case 5:
                        await DeletePatientAsync(clinicalService);
                        break;
                    case 6:
                        await BookAppointmentAsync(clinicalService);
                        return;
                    default:
                        Console.WriteLine("Invalid Choice. Please try again...");
                        break;
                }
            }
        }

        private static async Task DeletePatientAsync(IClinicService clinicalService)
        {
            Console.Write("Enter the Patient ID to delete: ");
            int patientId = int.Parse(Console.ReadLine());

            try
            {
                await clinicalService.DeletePatientAsync(patientId);
                Console.WriteLine("Patient deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        
    }

        private static async Task SearchByphoneAsync(IClinicService clinicalService)
        {
            Console.WriteLine("Enter Phone Number to search for the patient:");
            string phoneNumber = Console.ReadLine();

            Patient patient = await clinicalService.SearchPatientByPhoneNumberAsync(phoneNumber);

            if (patient != null)
            {
                Console.WriteLine($"Patient ID: {patient.PatientId}");
                Console.WriteLine($"Patient Name: {patient.PatientName}");
                Console.WriteLine($"DOB: {patient.DOB}");
                Console.WriteLine($"Gender: {patient.Gender}");
                Console.WriteLine($"Phone Number: {patient.PhoneNumber}");
                Console.WriteLine($"Address: {patient.Address}");
                Console.WriteLine($"Blood Group: {patient.Bloodgroup}");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }

            Console.ReadKey();
        }
    

    private static async Task SearchByIdIdAsync(IClinicService clinicalService)
        {
            Console.Write("Enter Patient ID to search: ");
            int patientId = Convert.ToInt32(Console.ReadLine());

            Patient patient = await clinicalService.SearchPatientByIdAsync(patientId);

            if (patient != null)
            {
                Console.WriteLine("Patient Details:");
                Console.WriteLine($"ID: {patient.PatientId}");
                Console.WriteLine($"Name: {patient.PatientName}");
                Console.WriteLine($"DOB: {patient.DOB}");
                Console.WriteLine($"Gender: {patient.Gender}");
                Console.WriteLine($"Phone: {patient.PhoneNumber}");
                Console.WriteLine($"Address: {patient.Address}");
                Console.WriteLine($"Blood Group: {patient.Bloodgroup}");
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }
        
    }

        private static async Task UpdatePatientAsync(IClinicService clinicalService)
        {
            Console.Write("Enter the Patient ID to update: ");
            int patientId = int.Parse(Console.ReadLine());

            Console.Write("Enter the updated Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Enter the updated Address: ");
            string address = Console.ReadLine();

            try
            {
                await clinicalService.UpdatePatientAsync(patientId, phoneNumber, address);
                Console.WriteLine("Patient updated successfully.");
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        
    }

        private static async Task PrescribeMedicationAsync(IClinicService clinicalService)
        {
            Console.Write("Enter Duration: ");
            int duration = int.Parse(Console.ReadLine());

            Console.Write("Enter Dosage: ");
            string dosage = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter Notes: ");
            string notes = Console.ReadLine();

            Console.Write("Enter Medicine ID: ");
            int medicineId = int.Parse(Console.ReadLine());

            Console.Write("Enter Appointment ID: ");
            int appointmentId = int.Parse(Console.ReadLine());

            await clinicalService.PrescribeMedicinesAsync(duration, dosage, quantity, notes, medicineId, appointmentId);
            Console.WriteLine("Medication prescribed successfully.");
        }
        private static async Task GoToDoctorDashboardAsync(IClinicService clinicalService)
        {
            Console.WriteLine("\n--- Doctor Dashboard ---");
            while (true)
            {
                Console.WriteLine("1. View Appointment");
                Console.WriteLine("2. Prescribe Medication");
                
                Console.WriteLine("3. Prescribe Test");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Your Choice: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5:");
                }

                switch (choice)
                {
                    case 1:
                        await GetAppointmentDetailsAsync(clinicalService);
                        break;
                    case 2:
                        await PrescribeMedicationAsync(clinicalService);
                        break;
                    case 3:
                        await PrescribeTestAsync(clinicalService);
                        break;
                    case 4:
                        //await PrescribeTestAsync(clinicalService);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice. Please try again...");
                        break;
                }
            }
        }

        private static async Task PrescribeTestAsync(IClinicService clinicalService)
        {
            Console.Write("Enter Appointment ID: ");
            int appointmentId = int.Parse(Console.ReadLine());

            Console.Write("Enter Test ID: ");
            int testId = int.Parse(Console.ReadLine());

            int newTestPrescriptionId = await clinicalService.PrescribeTestAsync(appointmentId, testId);
            Console.WriteLine($"Test Prescribed Successfully with Test Prescription ID: {newTestPrescriptionId}");
        }

        private static async Task GetAppointmentDetailsAsync(IClinicService clinicalService)
        {
            Console.WriteLine("Enter Appointment ID to view details:");
            int appointmentId = Convert.ToInt32(Console.ReadLine());

            AppointmentDetails appointmentDetails = clinicalService.GetAppointmentDetails(appointmentId);

            if (appointmentDetails != null)
            {
                Console.WriteLine($"Appointment ID: {appointmentDetails.AppointmentId}");
                Console.WriteLine($"Patient Name: {appointmentDetails.PatientName}");
                Console.WriteLine($"User Name: {appointmentDetails.UserName}");
                Console.WriteLine($"Staff Name: {appointmentDetails.StaffName}");
                Console.WriteLine($"Token Number: {appointmentDetails.TokenNumber}");
                Console.WriteLine($"Token Time: {appointmentDetails.TokenTime}");
                Console.WriteLine($"Token Date: {appointmentDetails.TokenDate}");
            }
            else
            {
                Console.WriteLine("Appointment not found.");
            }
        }

        private static async Task AddPatientAsync(IClinicService clinicalService)
        {
            var patient = new Patient();

            Console.Write("Enter the name of the patient: ");
            patient.PatientName = Console.ReadLine();

            DateTime dob;
            do
            {
                Console.Write("Enter the DOB of the patient (yyyy-mm-dd): ");
            } while (!DateTime.TryParse(Console.ReadLine(), out dob));
            patient.DOB = dob;

            Console.Write("Enter your Phone Number: ");
            patient.PhoneNumber = Console.ReadLine();

            Console.Write("Enter your Gender: ");
            patient.Gender = Console.ReadLine();

            Console.Write("Enter your Address: ");
            patient.Address = Console.ReadLine();

            Console.Write("Enter your Blood Group: ");
            patient.Bloodgroup = Console.ReadLine();

            await clinicalService.AddPatientAsync(patient);
            Console.WriteLine("Patient Added Successfully");
        }

        private static async Task BookAppointmentAsync(IClinicService clinicalService)
        {
            int patientId, userId, availabilityId, staffId;
            Console.Write("Enter Patient ID: ");
            patientId = int.Parse(Console.ReadLine());

            Console.Write("Enter User ID: ");
            userId = int.Parse(Console.ReadLine());

            Console.Write("Enter Availability ID: ");
            availabilityId = int.Parse(Console.ReadLine());

            Console.Write("Enter Staff ID: ");
            staffId = int.Parse(Console.ReadLine());

            // Initialize appointmentId and tokenId
            int appointmentId = 0;
            int tokenId = 0;

            // Book the appointment
            await Task.Run(() => clinicalService.BookAppointment(patientId, userId, availabilityId, staffId, out appointmentId, out tokenId));

            // Display the results
            Console.WriteLine($"Appointment booked successfully with Appointment ID: {appointmentId} and Token ID: {tokenId}");
        }
    }
}
