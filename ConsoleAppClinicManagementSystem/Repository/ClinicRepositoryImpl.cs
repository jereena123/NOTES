using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using ConsoleAppClinicManagementSystem.Model;
using SQLSERVERCONNECTIONLIBRARY;

namespace ConsoleAppClinicManagementSystem.Repository
{
    public class ClinicRepositoryImpl : IClinicRepository
    {
        private readonly string _connectionString;

        public ClinicRepositoryImpl(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task AddPatientAsync(Patient patient)
        {
            using (SqlConnection conn = SqlServerConnectionManager.OpenConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_ADDPatient", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PatientName", patient.PatientName);
                    command.Parameters.AddWithValue("@DOB", patient.DOB);
                    command.Parameters.AddWithValue("@Gender", patient.Gender);
                    command.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", patient.Address);
                    command.Parameters.AddWithValue("@BloodGroup", patient.Bloodgroup);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<(int StaffId, int RoleId)> GetStaffIdAndRoleIdAsync(string userName, string password)
        {
            int staffId = 0;
            int roleId = 0;

            using (SqlConnection conn = SqlServerConnectionManager.OpenConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_LoginAndGetRole1", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);

                    SqlParameter staffIdParam = new SqlParameter("@StaffId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(staffIdParam);

                    SqlParameter roleIdParam = new SqlParameter("@RoleId", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(roleIdParam);

                    await command.ExecuteNonQueryAsync();

                    staffId = staffIdParam.Value != DBNull.Value ? Convert.ToInt32(staffIdParam.Value) : 0;
                    roleId = roleIdParam.Value != DBNull.Value ? Convert.ToInt32(roleIdParam.Value) : 0;
                }
            }

            return (staffId, roleId);
        }

        public async Task<Patient> SearchPatientById(int patientId)
        {
            Patient patient = null;

            using (SqlConnection conn = SqlServerConnectionManager.OpenConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_SearchPatientById", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientId", patientId);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            patient = new Patient
                            {
                                PatientId = Convert.ToInt32(reader["PatientId"]),
                                PatientName = reader["PatientName"].ToString(),
                                DOB = Convert.ToDateTime(reader["DOB"]),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Address = reader["Address"].ToString(),
                                Bloodgroup = reader["BloodGroup"].ToString()
                            };
                        }
                    }
                }
            }

            return patient;
        }



        public async Task DeletePatientAsync(int patientId)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeletePatient", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@PatientId", patientId);

                    conn.Open();
                    try
                    {
                        await cmd.ExecuteNonQueryAsync();
                    }
                    catch (SqlException ex)
                    {
                        // Handle exceptions as needed
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        public void CreateAppointment(int patientId, int userId, int availabilityId, int staffId, out int appointmentId, out int tokenId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand("sp_CreateAppointment", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@PatientId", patientId);
                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@AvailabilityId", availabilityId);
                command.Parameters.AddWithValue("@StaffId", staffId);

                SqlParameter appointmentIdParam = new SqlParameter("@AppointmentId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(appointmentIdParam);

                SqlParameter tokenIdParam = new SqlParameter("@TokenId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(tokenIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                appointmentId = (int)appointmentIdParam.Value;
                tokenId = (int)tokenIdParam.Value;
            }
        }

        public AppointmentDetails GetAppointmentDetails(int appointmentId)
        {
            AppointmentDetails appointmentDetails = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_ViewAppointmentDetails", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);

                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        appointmentDetails = new AppointmentDetails
                        {
                            AppointmentId = Convert.ToInt32(reader["AppointmentId"]),
                            PatientId = Convert.ToInt32(reader["PatientId"]),
                            PatientName = reader["PatientName"].ToString(),
                            UserId = Convert.ToInt32(reader["UserId"]),
                            UserName = reader["UserName"].ToString(),
                            StaffId = Convert.ToInt32(reader["StaffId"]),
                            StaffName = reader["StaffName"].ToString(),
                            AvailabilityId = Convert.ToInt32(reader["AvailabilityId"]),
                            TokenId = Convert.ToInt32(reader["TokenId"]),
                            TokenNumber = Convert.ToInt32(reader["TokenNumber"]),
                            TokenTime = reader["TokenTime"].ToString(),
                            TokenDate = Convert.ToDateTime(reader["TokenDate"])
                        };
                    }
                }
            }

            return appointmentDetails;
        }

        public async Task PrescribeMedicinesAsync(int duration, string dosage, int quantity, string notes, int medicineId, int appointmentId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("PrescribeMedicines", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Duration", duration);
                    command.Parameters.AddWithValue("@Dosage", dosage);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Notes", notes);
                    command.Parameters.AddWithValue("@MedicineId", medicineId);
                    command.Parameters.AddWithValue("@AppointmentId", appointmentId);

                    connection.Open();
                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<int> PrescribeTestAsync(int appointmentId, int testId)
        {
            int newTestPrescriptionId;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_TestPrescription", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@AppointmentId", appointmentId);
                cmd.Parameters.AddWithValue("@TestId", testId);

                conn.Open();
                newTestPrescriptionId = (int)(decimal)await cmd.ExecuteScalarAsync();
            }

            return newTestPrescriptionId;
        }

        public async Task UpdatePatientAsync(int patientId, string phoneNumber, string address)
        {
            using (SqlConnection conn = SqlServerConnectionManager.OpenConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_UpdatePatient", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@PatientId", patientId);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Address", address);

                    await command.ExecuteNonQueryAsync();
                }
            }
        }

        public async Task<Patient> SearchPatientByIdAsync(int patientId)
        {
            Patient patient = null;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_SearchPatientById", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PatientId", patientId);

                    conn.Open();
                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            patient = new Patient
                            {
                                PatientId = Convert.ToInt32(reader["PatientId"]),
                                PatientName = reader["PatientName"].ToString(),
                                DOB = Convert.ToDateTime(reader["DOB"]),
                                Gender = reader["Gender"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Address = reader["Address"].ToString(),
                                Bloodgroup = reader["BloodGroup"].ToString()
                            };
                        }
                    }
                }
            }

            return patient;
        }

        public async Task<Patient> SearchPatientByPhoneNumberAsync(string phoneNumber)
        {
            Patient patient = null;

            using (SqlConnection conn = SqlServerConnectionManager.OpenConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("sp_SearchPatientByPhoneNumber", conn))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            patient = new Patient
                            {
                                PatientId = Convert.ToInt32(reader["PatientId"]),
                                PatientName = reader["PatientName"].ToString(),
                                DOB = Convert.ToDateTime(reader["DOB"]),
                                Gender = reader["Gender"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Address = reader["Address"].ToString(),
                                Bloodgroup = reader["BloodGroup"].ToString()
                            };
                        }
                    }
                }
            }

            return patient;
        }
    }
}
    

