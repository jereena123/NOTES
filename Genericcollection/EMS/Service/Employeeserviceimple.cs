using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Service
{
    public class EmployeeServiceImpl : IEmployeeService
    {
        // create a dictionary to store employee IDs
        // and corresponding employee details
        //int key to store employee
        //static allocates only one time memory for dic employees

        public static Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

        //Start with 1000 for 4 digit Employee ID
        private static int employeeIdGenerator = 1000;

        #region Add Employee
        public void AddEmployee()
        {
            //Exception handling
            try
            {
                //get input from the user
                Console.WriteLine("Enter employee details:");

                //employee name

                string name;
                //to validate name not empty and not a number
                while (true)
                {
                    Console.WriteLine("Employee name:");
                    name = Console.ReadLine();

                    //validation check
                    if (!string.IsNullOrWhiteSpace(name) && !System.Text.RegularExpressions.Regex.IsMatch(name, @"\d"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Employee Name.\nPlease ensure it is not empty and doesn't contain number");
                    }
                }

                //date of joining
                DateTime dateOfJoin;
                while (true)
                {
                    Console.WriteLine("Date of joining (YYYY-MM-DD):");
                    if (DateTime.TryParse(Console.ReadLine(), out dateOfJoin) &&
                        dateOfJoin >= DateTime.Now.AddDays(-5) && dateOfJoin <= DateTime.Now)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Date of Joining. Must be within the last 5 days. Please try again.");
                    }
                }

                //salary
                decimal salary;
                while (true)
                {
                    Console.WriteLine("Enter Salary:");
                    if (decimal.TryParse(Console.ReadLine(), out salary))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for salary. Please try again.");
                    }
                }

                //department id
                int departmentId;
                while (true)
                {
                    Console.WriteLine("Department: \n1. HR \n2. Admin \n3. IT \n4. Operation");
                    Console.WriteLine("Enter the department ID:");
                    if (int.TryParse(Console.ReadLine(), out departmentId) && departmentId >= 1 && departmentId <= 4)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Department ID. Please try again.");
                    }
                }

                //Department Name: automatically retrieve based on DeptId
                string departmentName = string.Empty;
                switch (departmentId)
                {
                    case 1:
                        departmentName = "HR";
                        break;
                    case 2:
                        departmentName = "Admin";
                        break;
                    case 3:
                        departmentName = "IT";
                        break;
                    case 4:
                        departmentName = "Operation";
                        break;
                }
                //latest c#
                /*
                string departmentName = departmentId switch
                {
                    1 => "HR",
                    2 => "Admin",
                    3 => "IT",
                    4 => "Operation",
                    _ => throw new ArgumentOutOfRangeException()
                };*/

                //InService
                bool inService;
                while (true)
                {
                    Console.WriteLine("Is the Employee in service (yes/no):");
                    string inServiceInput = Console.ReadLine().Trim().ToLower();
                    if (inServiceInput == "yes" || inServiceInput == "y")
                    {
                        inService = true;
                        break;
                    }
                    else if (inServiceInput == "no" || inServiceInput == "n")
                    {
                        inService = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for Inservice. Please enter 'yes' or 'no'.");
                    }
                }

                //Auto-generate Employee ID
                int employeeId = employeeIdGenerator++;
                Console.WriteLine($"Generated Employee Id: {employeeId}");

                //create an employee object and department obj to add it to the dictionary
                employees.Add(employeeId, new Employee
                {
                    //data member=value
                    Id = employeeId,
                    Name = name,
                    DateOfJoin = dateOfJoin,
                    Salary = salary,
                    InService = inService,
                    Dept = new Department
                    {
                        DepartmentId = departmentId,
                        DepartmentName = departmentName
                    }
                });
                Console.WriteLine("New employee added successfully.");
                Console.WriteLine($"Number of Employees: {employees.Count}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
        #endregion

      



        #region Search By ID

        public void SearchById(int employeeId)
        {
            try
            {
                if (employees.TryGetValue(employeeId, out Employee employee))
                {
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("| ID   | Name                | Salary     | Dept ID | In Service |");
                    Console.WriteLine("--------------------------------------------------------------------");

                    Console.WriteLine($"| {employee.Id,-4} | {employee.Name,-18} | {employee.Salary,-10:C} | {employee.Dept.DepartmentId,-6} | {employee.InService}");
                    Console.WriteLine("--------------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Update Employee

        public void UpdateEmployee(int employeeId)
        {
            try
            {
                if (!employees.ContainsKey(employeeId))
                {
                    Console.WriteLine("No Employee found.");
                    return;
                }
                else
                {
                    //fetch the employee details
                    Employee employee = employees[employeeId];
                    Console.WriteLine("Select the detail to update:");
                    Console.WriteLine("1. Salary");
                    Console.WriteLine("2. Department Id");
                    Console.WriteLine("3. Inservice");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Enter your choice");

                    int choice;
                    if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                        return;
                    }
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Existing salary is: " + employee.Salary);
                            decimal newSalary;
                            while (true)
                            {
                                Console.WriteLine("Enter new salary:");
                                if (decimal.TryParse(Console.ReadLine(), out newSalary))
                                {
                                    employee.Salary = newSalary;
                                    Console.WriteLine("New salary updated.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid salary. Please enter a valid number.");
                                }
                            }
                            break;

                        case 2:
                            Console.WriteLine($"Existing department id and name is: {employee.Dept.DepartmentId} ({employee.Dept.DepartmentName})");
                            int newDeptId;
                            while (true)
                            {
                                Console.WriteLine("Department: \n1. HR \n2. Admin \n3. IT \n4. Operation");
                                Console.WriteLine("Enter new department id:");

                                if (int.TryParse(Console.ReadLine(), out newDeptId) && newDeptId >= 1 && newDeptId <= 4)
                                {
                                    /*
                                    string newDepartmentName = newDeptId switch
                                    {
                                        1 => "HR",
                                        2 => "Admin",
                                        3 => "IT",
                                        4 => "Operation",
                                        _ => throw new ArgumentOutOfRangeException()
                                    };*/
                                    string newDepartmentName = string.Empty;
                                    switch (newDeptId)
                                    {
                                        case 1:
                                            newDepartmentName = "HR";
                                            break;
                                        case 2:
                                            newDepartmentName = "Admin";
                                            break;
                                        case 3:
                                            newDepartmentName = "IT";
                                            break;
                                    }
                                    employee.Dept.DepartmentId = newDeptId;
                                    employee.Dept.DepartmentName = newDepartmentName;

                                    Console.WriteLine("New department id and name updated.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input for Department ID. Please try again.");
                                }
                            }
                            break;

                        case 3:
                            Console.WriteLine("Existing inservice status is: " + employee.InService);
                            bool newInService;
                            while (true)
                            {
                                Console.WriteLine("Enter new inservice status (true/false):");

                                if (bool.TryParse(Console.ReadLine(), out newInService))
                                {
                                    employee.InService = newInService;
                                    Console.WriteLine("New inservice status updated.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input for Inservice status. Please enter 'true' or 'false'.");
                                }
                            }
                            break;

                        case 4:
                            return;
                    }

                    // Call method for displaying updated employee details
                    SearchById(employee.Id);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region Delete Employee
        public void DeleteEmployee(int employeeId)
        {
            try
            {
                if (!employees.ContainsKey(employeeId))
                {
                    Console.WriteLine("Employee not found:");
                    return;
                }
                var employee = employees[employeeId];
                //confirmation
                Console.Write($"Are you sure you want to delete employee{employeeId}({employee.Name})?(y/n):");
                char confirmation = Console.ReadLine().Trim().ToLower()[0];
                if (confirmation == 'y')
                {
                    employee.InService = false;
                    //employees.Remove(employeeId);
                    Console.WriteLine("Employee Deleted SuccessFully");
                    SearchById(employeeId);

                }
                else
                {
                    Console.WriteLine("Deletion cancelled");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void ListAllEmployee()
        {
            try
            {
                if (employees.Count == 0)
                {
                    Console.WriteLine("No employees found.");
                    return;
                }
                else
                {
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("| ID   | Name                | Salary              |");
                    Console.WriteLine("--------------------------------------------");

                    foreach (var employee in employees.Values)
                    {
                        Console.WriteLine($"| {employee.Id,-4} | {employee.Name,-18} | {employee.Salary,-18} |");
                    }
                    Console.WriteLine("--------------------------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }


        #endregion
    }
}