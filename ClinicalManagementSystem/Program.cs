using ClinicalManagementSystem.Service;
using ClinicalManagementSystem.Repository;
using ClinicalManagementSystem.Utility;
using System;
using System.Threading.Tasks;

namespace ClinicalManagementSystem
{
    public class Program
    {
        public static async Task Main(string[] args)
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

            try
            {
                // Inject the repository into the service
                IService loginService = new ServiceImple(new ClinicRepositoryImple());

              
                var (staffId, roleId) = await loginService.AuthenticateUserAsync(userName, password);

                if (staffId > 0)
                {
                    Console.WriteLine($"Login successful. StaffId: {staffId}, RoleId: {roleId}");

                   
                    switch (roleId)
                    {
                        case 1:
                            Console.WriteLine("You are logged in as Receptionist.");
                            await ReceptionistMenuAsync(loginService);
                            break;
                        case 2:
                            Console.WriteLine("You are logged in as Doctor.");
                           
                            break;
                        
                        default:
                            Console.WriteLine("Unknown role");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid credentials");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private static async Task ReceptionistMenuAsync(IService clinicService)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Receptionist Dashboard");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Search Patient");
                Console.WriteLine("3. Exit");

                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        await AddPatientAsync(clinicService);
                        break;
                    case "2":
                        await SearchPatientAsync(clinicService);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static async Task AddPatientAsync(IService clinicService)
        {
            Console.WriteLine("Enter Patient Details");

            Console.Write(" Name: ");
            string Name = Console.ReadLine();

           

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            bool exists = await clinicService.CheckPatientExistsAsync(Name, phoneNumber);

            if (exists)
            {
                Console.WriteLine("Patient already exists.");
                return;
            }

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Date of Birth (yyyy-mm-dd): ");
            DateTime dob;
            while (!DateTime.TryParse(Console.ReadLine(), out dob))
            {
                Console.Write("Invalid date format. Please enter again (yyyy-mm-dd): ");
            }

            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Blood Group: ");
            string bloodGroup = Console.ReadLine();

            Patient newPatient = new Patient
            {
                PatientName = $"{firstName} {lastName}",
                PhoneNumber = phoneNumber,
                DOB = dob,
                Gender = gender,
                Address = address,
                Bloodgroup = bloodGroup
            };

            await clinicService.AddPatientAsync(newPatient);
            Console.WriteLine("Patient added successfully.");
        }

        private static async Task SearchPatientAsync(IService clinicService)
        {
            Console.WriteLine("Search Patient");
            Console.WriteLine("1. Search by Name and Phone Number");
            Console.WriteLine("2. Search by Patient ID");
            Console.WriteLine("3. Return to Main Menu");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    await SearchPatientByNameAndPhoneAsync(clinicService);
                    break;
                case "2":
                    await SearchPatientByIdAsync(clinicService);
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        private static async Task SearchPatientByNameAndPhoneAsync(IService clinicService)
        {
            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Patient patient = await clinicService.GetPatientByNameAndPhoneAsync(firstName, phoneNumber);

            if (patient == null)
            {
                Console.WriteLine("Patient not found.");
                return;
            }

            Console.WriteLine("Patient Found:");
            Console.WriteLine($"ID: {patient.PatientId}");
            Console.WriteLine($"Name: {patient.PatientName}");
            Console.WriteLine($"Phone Number: {patient.PhoneNumber}");
            Console.WriteLine($"Address: {patient.Address}");
            Console.WriteLine($"Date of Birth: {patient.DOB.ToShortDateString()}");
            Console.WriteLine($"Gender: {patient.Gender}");
            Console.WriteLine($"Blood Group: {patient.Bloodgroup}");

            Console.WriteLine("Select Action:");
            Console.WriteLine("1. Edit");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Return to Search Menu");

            var action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    await EditPatientAsync(clinicService, patient.PatientId);
                    break;
                case "2":
                    await clinicService.DeletePatientAsync(patient.PatientId);
                    Console.WriteLine("Patient deleted successfully.");
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        private static async Task SearchPatientByIdAsync(IService clinicService)
        {
            Console.Write("Enter Patient ID: ");
            int patientId;
            if (!int.TryParse(Console.ReadLine(), out patientId))
            {
                Console.WriteLine("Invalid Patient ID.");
                return;
            }

            Patient patient = await clinicService.GetPatientByIdAsync(patientId);

            if (patient == null)
            {
                Console.WriteLine("Patient not found.");
                return;
            }

            Console.WriteLine("Patient Found:");
            Console.WriteLine($"ID: {patient.PatientId}");
            Console.WriteLine($"Name: {patient.PatientName}");
            Console.WriteLine($"Phone Number: {patient.PhoneNumber}");
            Console.WriteLine($"Address: {patient.Address}");
            Console.WriteLine($"Date of Birth: {patient.DOB.ToShortDateString()}");
            Console.WriteLine($"Gender: {patient.Gender}");
            Console.WriteLine($"Blood Group: {patient.Bloodgroup}");

            Console.WriteLine("Select Action:");
            Console.WriteLine("1. Edit");
            Console.WriteLine("2. Delete");
            Console.WriteLine("3. Return to Search Menu");

            var action = Console.ReadLine();
            switch (action)
            {
                case "1":
                    await EditPatientAsync(clinicService, patient.PatientId);
                    break;
                case "2":
                    await clinicService.DeletePatientAsync(patient.PatientId);
                    Console.WriteLine("Patient deleted successfully.");
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        private static async Task EditPatientAsync(IService clinicService, int patientId)
        {
            Console.WriteLine("Edit Patient Details");

            var patient = await clinicService.GetPatientByIdAsync(patientId);
            if (patient == null)
            {
                Console.WriteLine("Patient not found.");
                return;
            }

            Console.Write($"First Name [{patient.PatientName}]: ");
            var patientName = Console.ReadLine();
            patient.PatientName = string.IsNullOrWhiteSpace(patientName) ? patient.PatientName : patientName;

            Console.Write($"Phone Number [{patient.PhoneNumber}]: ");
            var phoneNumber = Console.ReadLine();
            patient.PhoneNumber = string.IsNullOrWhiteSpace(phoneNumber) ? patient.PhoneNumber : phoneNumber;

            Console.Write($"Address [{patient.Address}]: ");
            var address = Console.ReadLine();
            patient.Address = string.IsNullOrWhiteSpace(address) ? patient.Address : address;

            Console.Write($"Date of Birth [{patient.DOB.ToShortDateString()}] (yyyy-mm-dd): ");
            var dobInput = Console.ReadLine();
            if (DateTime.TryParse(dobInput, out DateTime dob))
            {
                patient.DOB = dob;
            }

            Console.Write($"Gender [{patient.Gender}]: ");
            var gender = Console.ReadLine();
            patient.Gender = string.IsNullOrWhiteSpace(gender) ? patient.Gender : gender;

            Console.Write($"Blood Group [{patient.Bloodgroup}]: ");
            var bloodGroup = Console.ReadLine();
            patient.Bloodgroup = string.IsNullOrWhiteSpace(bloodGroup) ? patient.Bloodgroup : bloodGroup;

            await clinicService.UpdatePatientAsync(patient);
            Console.WriteLine("Patient updated successfully.");
        }
    }
}
