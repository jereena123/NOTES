using ConsoleAppClinicManagementSystem.Model;
using ConsoleAppClinicManagementSystem.Repository;
using ConsoleAppClinicManagementSystem.Service;
using ConsoleAppClinicManagementSystem.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem
{
    public class Program
    {
        static IClinicService clinicalService = new ClinicServiceImpl(new ClinicRepositoryImpl());

        static async Task Main(string[] args)
        {
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
                Console.WriteLine($"Login successfully. StaffId: {staffId}, RoleId: {roleId}");
                switch (roleId)
                {
                    case 1:
                        await GoToReceptionistDashboardAsync(clinicalService);
                        break;
                    case 2:
                        GoToDoctorDashboard();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid credentials");
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
                Console.WriteLine("2. Search Patient");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");
                Console.WriteLine("5. Exit");

                
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
                        //await SearchPatientAsync(clinicalService);
                        break;
                    case 3:
                        await UpdatePatientAsync(clinicalService);
                        break;
                    case 4:
                        //await DeletePatientAsync(clinicalService);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid Choice. Please try again...");
                        break;
                }
            }
        }

        private static void GoToDoctorDashboard()
        {
            Console.WriteLine("\n--- Doctor Dashboard ---");
            // Doctor-specific functions
            Console.WriteLine("1. View Appointment");
            Console.WriteLine("2. Update Medical Records");
            Console.WriteLine("3. Prescribe Medication");
            Console.WriteLine("4. Prescribe Test");
        }

        #region AddPatient
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
            patient.BloodGroup = Console.ReadLine();

            Console.Write("Enter your Email: ");
            patient.Email = Console.ReadLine();

            await clinicalService.AddPatientAsync(patient);
            Console.Write("Patient Added Successfully");
        }
        #endregion

        private static async Task UpdatePatientAsync(IClinicService clinicalService)
        {
            var patient = new Patient();

            // Collect the patient ID to update
            Console.Write("Enter the Patient ID to update: ");
            patient.PatientId = int.Parse(Console.ReadLine());

            // Collect the updated patient details
            Console.Write("Enter the updated name of the patient: ");
            patient.PatientName = Console.ReadLine();

            Console.Write("Enter the updated DOB of the patient: ");
            patient.DOB = DateTime.Parse(Console.ReadLine());

            Console.Write("Enter the updated Phone Number: ");
            patient.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter the updated Gender: ");
            patient.Gender = Console.ReadLine();

            Console.WriteLine("Enter the updated Address: ");
            patient.Address = Console.ReadLine();

            Console.WriteLine("Enter the updated Blood Group: ");
            patient.BloodGroup = Console.ReadLine();

            Console.Write("Enter the updated Email: ");
            patient.Email = Console.ReadLine();

            // Update the patient using the service
            await clinicalService.UpdatePatientAsync(patient);
            Console.WriteLine("Patient Updated Successfully");
        }


    }
}
