using ConsoleAppFlightMachineTest.Model;
using ConsoleAppFlightMachineTest.Repository;
using ConsoleAppFlightMachineTest.Service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Configuration;
using SqlServerConnectionLibraryDatabase;


namespace ConsoleAppFlightMachineTest
{
    public class Program
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["CsWin"].ConnectionString;
        private static readonly IFlightRepository FlightRepository = new FlightRepositoryImpl(connectionString);
        private static readonly IFlightService FlightService = new FlightServiceImpl(FlightRepository);

        static async Task Main(string[] args)
        {
            // Main menu and other code...
            await MenuAsync(args);
        }

        public static async Task MenuAsync(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Admin Dashboard:");
                Console.WriteLine("1. List All Flights");
                Console.WriteLine("2. Search Flight By ID");
                Console.WriteLine("3. Add Flight");
                Console.WriteLine("4. Update Flight");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        await ListAllFlightsAsync();
                        break;

                    case "2":
                        await SearchFlightByIdAsync();
                        break;

                    case "3":
                        await AddFlightAsync();
                        break;

                    case "4":
                        await UpdateFlightAsync();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        private static async Task ListAllFlightsAsync()
        {
            Console.WriteLine("Fetching all flights...");
            var flights = await FlightService.GetAllFlightsAsync();

            foreach (var flight in flights)
            {
                Console.WriteLine($"Flight ID: {flight.FlightId}");
                Console.WriteLine($"Departure Airport: {flight.DepartureAirport}");
                Console.WriteLine($"Departure Date: {flight.DepartureDate:yyyy-MM-dd}");
                Console.WriteLine($"Departure Time: {flight.DepartureTime:hh\\:mm\\:ss}");
                Console.WriteLine($"Arrival Airport: {flight.ArrivalAirport}");
                Console.WriteLine($"Arrival Date: {flight.ArrivalDate:yyyy-MM-dd}");
                Console.WriteLine($"Arrival Time: {flight.ArrivalTime:hh\\:mm\\:ss}");
                Console.WriteLine();
            }
        }

        private static async Task SearchFlightByIdAsync()
        {
            Console.Write("Enter Flight ID to search: ");
            if (int.TryParse(Console.ReadLine(), out int flightId))
            {
                var flight = await FlightService.GetFlightByIdAsync(flightId);

                if (flight != null)
                {
                    Console.WriteLine($"Flight ID: {flight.FlightId}");
                    Console.WriteLine($"Departure Airport: {flight.DepartureAirport}");
                    Console.WriteLine($"Departure Date: {flight.DepartureDate:yyyy-MM-dd}");
                    Console.WriteLine($"Departure Time: {flight.DepartureTime:hh\\:mm\\:ss}");
                    Console.WriteLine($"Arrival Airport: {flight.ArrivalAirport}");
                    Console.WriteLine($"Arrival Date: {flight.ArrivalDate:yyyy-MM-dd}");
                    Console.WriteLine($"Arrival Time: {flight.ArrivalTime:hh\\:mm\\:ss}");
                }
                else
                {
                    Console.WriteLine("Flight not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Flight ID.");
            }
        }

        private static async Task AddFlightAsync()
        {
            var flight = new Flight();

            Console.Write("Departure Airport: ");
            flight.DepartureAirport = Console.ReadLine();

            Console.Write("Departure Date (YYYY-MM-DD): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime depDate))
            {
                flight.DepartureDate = depDate;
            }
            else
            {
                Console.WriteLine("Invalid date format.");
                return;
            }

            Console.Write("Departure Time (HH:MM:SS): ");
            if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan depTime))
            {
                flight.DepartureTime = depTime;
            }
            else
            {
                Console.WriteLine("Invalid time format.");
                return;
            }

            Console.Write("Arrival Airport: ");
            flight.ArrivalAirport = Console.ReadLine();

            Console.Write("Arrival Date (YYYY-MM-DD): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime arrDate))
            {
                flight.ArrivalDate = arrDate;
            }
            else
            {
                Console.WriteLine("Invalid date format.");
                return;
            }

            Console.Write("Arrival Time (HH:MM:SS): ");
            if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan arrTime))
            {
                flight.ArrivalTime = arrTime;
            }
            else
            {
                Console.WriteLine("Invalid time format.");
                return;
            }

            await FlightService.AddFlightAsync(flight);
            Console.WriteLine("Flight added successfully.");
        }

        private static async Task UpdateFlightAsync()
        {
            Console.Write("Enter Flight ID to update: ");
            if (int.TryParse(Console.ReadLine(), out int flightId))
            {
                var flight = await FlightService.GetFlightByIdAsync(flightId);

                if (flight != null)
                {
                    Console.Write("New Departure Airport: ");
                    flight.DepartureAirport = Console.ReadLine();

                    Console.Write("New Departure Date (YYYY-MM-DD): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime depDate))
                    {
                        flight.DepartureDate = depDate;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format.");
                        return;
                    }

                    Console.Write("New Departure Time (HH:MM:SS): ");
                    if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan depTime))
                    {
                        flight.DepartureTime = depTime;
                    }
                    else
                    {
                        Console.WriteLine("Invalid time format.");
                        return;
                    }

                    Console.Write("New Arrival Airport: ");
                    flight.ArrivalAirport = Console.ReadLine();

                    Console.Write("New Arrival Date (YYYY-MM-DD): ");
                    if (DateTime.TryParse(Console.ReadLine(), out DateTime arrDate))
                    {
                        flight.ArrivalDate = arrDate;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format.");
                        return;
                    }

                    Console.Write("New Arrival Time (HH:MM:SS): ");
                    if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan arrTime))
                    {
                        flight.ArrivalTime = arrTime;
                    }
                    else
                    {
                        Console.WriteLine("Invalid time format.");
                        return;
                    }

                    await FlightService.UpdateFlightAsync(flight);
                    Console.WriteLine("Flight updated successfully.");
                }
                else
                {
                    Console.WriteLine("Flight not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Flight ID.");
            }
        }
    }
}
