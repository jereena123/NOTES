using ConsoleEmployeeApp.DataAccessLayer;
using ConsoleEmployeeApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEmployeeApp.BusinessLayer
{
    public class EmployeeServiceImple : IEmployeeService
    {
        
             //Fileld data member
        private readonly IEmployeeRepository _employeeRepository;

        //Constructor Injection
        public EmployeeServiceImple(IEmployeeRepository employeeRepository)
        {

            _employeeRepository = employeeRepository;

        }
    
    List<Employee>IEmployeeService. ListAllEmployeeService()
    {
            return _employeeRepository.LoadEmployee();
    }

        public void SaveEmployeeService(List<Employee> employees)
        {
            _employeeRepository.SaveEmployees(employees);
        }
    }
}





