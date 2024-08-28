using ConsoleAppFlightMachineTest.Model;
using ConsoleAppFlightMachineTest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlServerConnectionLibraryDatabase;

namespace ConsoleAppFlightMachineTest.Service
{
    public class FlightServiceImpl : IFlightService
    {
        private readonly IFlightRepository _flightRepository;

        public FlightServiceImpl(IFlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }
        /*public async Task<int> AuthenticateUserAsync(string Username, string Password)
        {
            //checking Business rules for validation
            return await _flightRepository.GetStaffIdAsync(Username, Password);
        }*/

        public async Task<List<Flight>> GetAllFlightsAsync()
        {
            return await _flightRepository.ListAllFlightsAsync();
        }

        public async Task<Flight> GetFlightByIdAsync(int flightId)
        {
            return await _flightRepository.GetFlightByIdAsync(flightId);
        }

        public async Task AddFlightAsync(Flight flight)
        {
            await _flightRepository.AddFlightAsync(flight);
        }

        public async Task UpdateFlightAsync(Flight flight)
        {
            await _flightRepository.UpdateFlightAsync(flight);
        }
    }
}