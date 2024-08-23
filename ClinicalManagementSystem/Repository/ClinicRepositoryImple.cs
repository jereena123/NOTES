using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Repository
{
    public class ClinicRepositoryImple : IClinicRepository
    {
        string WindowconnString = ConfigurationManager.ConnectionStrings["CSHARPWINDOW"].ConnectionString;

        public async Task<(int StaffId, int RoleId)> GetRoleIdAsync(string userName, string password)
        {
            int staffId = 0;
            int roleId = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(WindowconnString))
                {
                    await conn.OpenAsync();
                    using (SqlCommand command = new SqlCommand("sp_LoginAndGetRole1", conn))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@UserName", userName);
                        command.Parameters.AddWithValue("@Password", password);

                        SqlParameter staffIdParam = new SqlParameter("@StaffId", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        SqlParameter roleIdParam = new SqlParameter("@RoleId", SqlDbType.Int)
                        {
                            Direction = ParameterDirection.Output
                        };
                        command.Parameters.Add(staffIdParam);
                        command.Parameters.Add(roleIdParam);

                        await command.ExecuteNonQueryAsync();
                    

                    if (staffIdParam.Value != DBNull.Value && roleIdParam.Value != DBNull.Value)
                        {
                            staffId = Convert.ToInt32(staffIdParam.Value);
                            roleId = Convert.ToInt32(roleIdParam.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return (staffId, roleId); // Return both StaffId and RoleId as a tuple
        }
        public async Task<bool> CheckPatientExistsAsync(string name, string phoneNumber)
        {
            bool exists = false;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    string query = "SELECT COUNT(*) FROM Patient WHERE PatientName = @Name AND PhoneNumber = @PhoneNumber";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        int count = (int)await command.ExecuteScalarAsync();
                        exists = count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
            }

            return exists;
        }

        public async Task AddPatientAsync(Patient patient)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    string query = "INSERT INTO Patient (PatientName, DOB, PhoneNumber, Gender, Address, Bloodgroup) VALUES (@Name, @DOB, @PhoneNumber, @Gender, @Address, @Bloodgroup)";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Name", patient.PatientName);
                        command.Parameters.AddWithValue("@DOB", patient.DOB);
                        command.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                        command.Parameters.AddWithValue("@Gender", patient.Gender);
                        command.Parameters.AddWithValue("@Address", patient.Address);
                        command.Parameters.AddWithValue("@Bloodgroup", patient.Bloodgroup);

                        await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task<Patient> GetPatientByNameAndPhoneAsync(string name, string phoneNumber)
        {
            Patient patient = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    string query = "SELECT * FROM Patient WHERE PatientName = @Name AND PhoneNumber = @PhoneNumber";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                patient = new Patient
                                {
                                    PatientId = reader.GetInt32(reader.GetOrdinal("PatientId")),
                                    PatientName = reader.GetString(reader.GetOrdinal("PatientName")),
                                    DOB = reader.GetDateTime(reader.GetOrdinal("DOB")),
                                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    Bloodgroup = reader.GetString(reader.GetOrdinal("Bloodgroup"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
            }

            return patient;
        }

        public async Task<Patient> GetPatientByIdAsync(int patientId)
        {
            Patient patient = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    string query = "SELECT * FROM Patient WHERE PatientId = @PatientId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@PatientId", patientId);

                        using (SqlDataReader reader = await command.ExecuteReaderAsync())
                        {
                            if (reader.Read())
                            {
                                patient = new Patient
                                {
                                    PatientId = reader.GetInt32(reader.GetOrdinal("PatientId")),
                                    PatientName = reader.GetString(reader.GetOrdinal("PatientName")),
                                    DOB = reader.GetDateTime(reader.GetOrdinal("DOB")),
                                    PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
                                    Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                    Address = reader.GetString(reader.GetOrdinal("Address")),
                                    Bloodgroup = reader.GetString(reader.GetOrdinal("Bloodgroup"))
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
            }

            return patient;
        }

        public async Task UpdatePatientAsync(Patient patient)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    string query = "UPDATE Patient SET PatientName = @Name, DOB = @DOB, PhoneNumber = @PhoneNumber, Gender = @Gender, Address = @Address, Bloodgroup = @Bloodgroup WHERE PatientId = @PatientId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Name", patient.PatientName);
                        command.Parameters.AddWithValue("@DOB", patient.DOB);
                        command.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                        command.Parameters.AddWithValue("@Gender", patient.Gender);
                        command.Parameters.AddWithValue("@Address", patient.Address);
                        command.Parameters.AddWithValue("@Bloodgroup", patient.Bloodgroup);
                        command.Parameters.AddWithValue("@PatientId", patient.PatientId);

                        await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public async Task DeletePatientAsync(int patientId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    await conn.OpenAsync();
                    string query = "DELETE FROM Patient WHERE PatientId = @PatientId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@PatientId", patientId);
                        await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }


}
}
