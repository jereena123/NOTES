using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLSERVERCONNECTIONLIBRARY;

namespace SQLSERVERCONNECTIONTESTDEMO
{
    internal class Program
    {
        //1 Retreive ConnectionString from App.Config
        //2 Passing ConnectionString to dll as
        //OpenConnection(string connstring) method
        //3 Establish Connection
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("TRYING TO CONNECT TO DATABASE");

                //1 Retreive ConnectionString from App.Config
                string WindowconnString = ConfigurationManager.ConnectionStrings["CSHARPWINDOW"].ConnectionString;
                //2 Passing ConnectionString to dll as
                //OpenConnnection (string connstring) method
                
                SqlConnection con = SqlServerConnectionManager.OpenConnection(WindowconnString);
                if (con != null)
                {
                    Console.WriteLine("Connection established successfully");
                }
                else
                {
                    Console.WriteLine("Conection failed");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("OOPS"+ex);
            }
            Console.WriteLine("press any key to exit...");
            Console.ReadKey();

        }
    }
}
