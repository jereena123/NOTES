using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppone
{
    internal class Q4_assignment
    {
        static void Main(string[] args)
        {
            //initialize attempt,username,password
            int attempt = 0;
            string username;
            string password;
            //while loop 
            while (attempt < 3)
            {

                Console.WriteLine("Enter Username:");
                username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine();
                //if condition for checking username and password
                if ((username == "user") && (password == "pass"))
                {
                    Console.WriteLine("Login Successful!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid password");

                }
                //post increment
                attempt++;

            }
            //pause screen
            Console.WriteLine("press any key to continue");
            Console.ReadKey();

        }
    }
}
