using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SqlServerConnectionLibraryDatabase;
using ConsoleAppClinicManagementSystem.Model;

namespace ConsoleAppClinicManagementSystem.Repository
{
    public class ClinicRepositoryImpl : IClinicRepository
    {
       
            // Connection string
            private readonly string connString = ConfigurationManager.ConnectionStrings["CsWin"].ConnectionString;
        private string _connectionString;

        public async Task AddPatientAsync(Patient patient)
        {
            
                using (SqlConnection conn = SqlServerConnectionManager.OpenConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand("[dbo].[sp_AddPatient]", conn))
                    {
                        //using stored procedure
                        command.CommandType = CommandType.StoredProcedure;

                        //Input parameters
                        command.Parameters.AddWithValue("@PatientName", patient.PatientName);
                        command.Parameters.AddWithValue("@DOB", patient.DOB);
                        command.Parameters.AddWithValue("@Gender", patient.Gender);
                        command.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                        command.Parameters.AddWithValue("@Address", patient.Address);
                        command.Parameters.AddWithValue("@BloodGroup", patient.BloodGroup);
                        command.Parameters.AddWithValue("@Email", patient.Email);

                    await command.ExecuteNonQueryAsync();

                    }

                }
            }
        

        public Task DeletePatientAsync(int PatientId)
        {
            throw new NotImplementedException();
        }

        public async Task<(int StaffId, int RoleId)> GetStaffIdAndRoleIdAsync(string userName, string password)
            {
                int staffId = 0;
                int roleId = 0;

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    using (SqlCommand command = new SqlCommand("sp_LoginAndGetRole", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        // Input parameters
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);

                        // Output parameters
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

                        await conn.OpenAsync();
                        await command.ExecuteNonQueryAsync();

                        // Retrieve output parameters
                        if (staffIdParam.Value != DBNull.Value)
                        {
                            staffId = Convert.ToInt32(staffIdParam.Value);
                        }
                        if (roleIdParam.Value != DBNull.Value)
                        {
                            roleId = Convert.ToInt32(roleIdParam.Value);
                        }
                    }
                }

                return (staffId, roleId);
            }

        
        
    

        public Task<Patient> SearchPatientById(int PatientId)
        {
            throw new NotImplementedException();
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePatient", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    cmd.Parameters.AddWithValue("@PatientId", patient.PatientId);
                    cmd.Parameters.AddWithValue("@PatientName", patient.PatientName);
                    cmd.Parameters.AddWithValue("@DOB", patient.DOB);
                    cmd.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                    cmd.Parameters.AddWithValue("@Address", patient.Address);
                    cmd.Parameters.AddWithValue("@BloodGroup", patient.BloodGroup);
                    cmd.Parameters.AddWithValue("@Email", patient.Email);

                    conn.Open();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
    }
    
