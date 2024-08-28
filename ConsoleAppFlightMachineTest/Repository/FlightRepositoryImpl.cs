using ConsoleAppFlightMachineTest.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlServerConnectionLibraryDatabase;

namespace ConsoleAppFlightMachineTest.Repository
{

    public class FlightRepositoryImpl : IFlightRepository
    {
        private readonly string _connectionString;

        public FlightRepositoryImpl(string connectionString)
        {
            _connectionString = connectionString;
        }
       

        public async Task<List<Flight>> ListAllFlightsAsync()
        {
            var flights = new List<Flight>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("sp_ListAllFlights", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        flights.Add(new Flight
                        {
                            FlightId = reader.GetInt32(0),
                            DepartureAirport = reader.GetString(1),
                            DepartureDate = reader.GetDateTime(2),
                            DepartureTime = reader.GetTimeSpan(3),
                            ArrivalAirport = reader.GetString(4),
                            ArrivalDate = reader.GetDateTime(5),
                            ArrivalTime = reader.GetTimeSpan(6)
                        });
                    }
                }
            }

            return flights;
        }

        public async Task<Flight> GetFlightByIdAsync(int flightId)
        {
            Flight flight = null;

            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("sp_GetFlightById", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@FlightId", flightId);

                await connection.OpenAsync();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        flight = new Flight
                        {
                            FlightId = reader.GetInt32(0),
                            DepartureAirport = reader.GetString(1),
                            DepartureDate = reader.GetDateTime(2),
                            DepartureTime = reader.GetTimeSpan(3),
                            ArrivalAirport = reader.GetString(4),
                            ArrivalDate = reader.GetDateTime(5),
                            ArrivalTime = reader.GetTimeSpan(6)
                        };
                    }
                }
            }

            return flight;
        }

        public async Task AddFlightAsync(Flight flight)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("sp_AddFlight", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@DepAirport", flight.DepartureAirport);
                command.Parameters.AddWithValue("@DepDate", flight.DepartureDate);
                command.Parameters.AddWithValue("@DepTime", flight.DepartureTime);
                command.Parameters.AddWithValue("@ArrAirport", flight.ArrivalAirport);
                command.Parameters.AddWithValue("@ArrDate", flight.ArrivalDate);
                command.Parameters.AddWithValue("@ArrTime", flight.ArrivalTime);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task UpdateFlightAsync(Flight flight)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = new SqlCommand("sp_UpdateFlight", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@FlightId", flight.FlightId);
                command.Parameters.AddWithValue("@DepAirport", flight.DepartureAirport);
                command.Parameters.AddWithValue("@DepDate", flight.DepartureDate);
                command.Parameters.AddWithValue("@DepTime", flight.DepartureTime);
                command.Parameters.AddWithValue("@ArrAirport", flight.ArrivalAirport);
                command.Parameters.AddWithValue("@ArrDate", flight.ArrivalDate);
                command.Parameters.AddWithValue("@ArrTime", flight.ArrivalTime);

                await connection.OpenAsync();
                await command.ExecuteNonQueryAsync();
            }
        }
    }
}