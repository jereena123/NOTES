using EMS.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS
{
    public class Emsv2024
    {
        // 1-fields
        private readonly IEmployeeService _employeeServices;

        // 2-Constructor Injection
        public Emsv2024 (IEmployeeService employeeServices)
        {
            _employeeServices = employeeServices;
        }
        static void Main(string[] args)
        {
            //create an object
            //IEmployeeServices _employeeService = new EmployeeServicesImpl();
            //_employeeServices.AddEmployee();

            var empApp = new Emsv2024(new EmployeeServiceImpl());


            //Menu Driven
            while (true)
            {
                Console.WriteLine("\nEmployee Management System");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Search  Employee By Id ");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. List All Employee");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice: ");

                //Valide Choice
                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
                }

                //Condition Check
                switch (choice)
                {
                    case 1:
                        //Add Employee
                        empApp._employeeServices.AddEmployee();
                        break;
                    case 2:
                        //Update employee
                        Console.WriteLine("Enter Employee Id to update: ");
                        if (int.TryParse(Console.ReadLine(), out int updateId))
                        {
                            empApp._employeeServices.UpdateEmployee(updateId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Employee ID.");
                        }
                        break;
                    case 3:
                        //Search employee
                        Console.WriteLine("Enter Employee Id to Search: ");
                        if (int.TryParse(Console.ReadLine(), out int SearchId))
                        {
                            empApp._employeeServices.SearchById(SearchId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Employee ID.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Employee Id to Delete: ");
                        if (int.TryParse(Console.ReadLine(), out int DeleteId))
                        {
                            empApp._employeeServices.DeleteEmployee(DeleteId);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Employee ID.");
                        }
                        break;
                    case 5:
                        empApp._employeeServices.ListAllEmployee();
                        break;
                    case 6:
                        return;
                
                }
            }

        }
    }
}



