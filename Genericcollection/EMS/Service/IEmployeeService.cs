using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Service
{
    public interface IEmployeeService
    {
        //crud operations--businesslogic
        void AddEmployee();
        void ListAllEmployee();
        void SearchById(int employeeId);
        void UpdateEmployee(int employeeId);
        void DeleteEmployee(int employeeId);

    }
}

