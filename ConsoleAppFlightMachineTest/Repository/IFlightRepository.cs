using ConsoleAppFlightMachineTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlServerConnectionLibraryDatabase;
namespace ConsoleAppFlightMachineTest.Repository
{
    public interface IFlightRepository
    {
        Task<List<Flight>> ListAllFlightsAsync();
        Task<Flight> GetFlightByIdAsync(int flightId);
        Task AddFlightAsync(Flight flight);
        Task UpdateFlightAsync(Flight flight);


    }
}
