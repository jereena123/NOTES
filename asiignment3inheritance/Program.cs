using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asiignment3inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
                try
                {
                    Employee emp1 = new Employee(1, "John Doe", "Manager", 8000);
                    emp1.DisplayDetails();
                    Console.WriteLine();

                    Executive exec1 = new Executive(2, "Jane Smith", "Senior Executive", 15000);
                    exec1.DisplayDetails();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

